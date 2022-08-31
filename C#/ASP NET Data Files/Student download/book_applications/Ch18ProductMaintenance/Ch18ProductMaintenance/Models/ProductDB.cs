using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// make sure to include these using directives
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Ch18ProductMaintenance.Models
{
    public class ProductDB
    {
        // private data object and contructor
        HalloweenEntities db;
        public ProductDB()
        {
            db = new HalloweenEntities();
        }

        // Select methods
        public IQueryable<Category> GetCategories()
        {
            return from c in db.Categories
                   orderby c.LongName
                   select c;
        }
        public IQueryable<Product> GetProducts()
        {
            return from p in db.Products
                   orderby p.Name
                   select p;
        }
        public Product GetProduct([Control] string grdProducts)
        {
            // return first Product if no value passed from GridView
            if (grdProducts == null)
                return (from p in db.Products
                        orderby p.Name
                        select p).FirstOrDefault();
            else
                return GetProductById(grdProducts);
        }

        // Insert method
        public void InsertProduct(ModelMethodContext cxt)
        {
            var item = new Product();
            cxt.TryUpdateModel(item);
            if (cxt.ModelState.IsValid)
            {
                db.Products.Add(item);
                try {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex) {
                    HandleValidationError(ex, cxt);
                }
                catch (Exception ex) {
                    HandleError(ex, cxt);
                }
            }
        }

        // Update method
        public void UpdateProduct(string ProductID, ModelMethodContext cxt)
        {
            Product item = GetProductById(ProductID);
            if (item == null) {
                cxt.ModelState.AddModelError("", $"Item with id {ProductID} was not found");
                return;
            }
            cxt.TryUpdateModel(item);
            if (cxt.ModelState.IsValid)
            {
                try {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex) {
                    HandleConcurrencyError(ex, cxt, IsEdit: true);
                }
                catch (DbEntityValidationException ex) {
                    HandleValidationError(ex, cxt);
                }
                catch (Exception ex) {
                    HandleError(ex, cxt);
                }
            }
        }

        // Delete method
        public void DeleteProduct(string ProductID, ModelMethodContext cxt)
        {
            Product item = GetProductById(ProductID);
            if (item != null) // the product hasn't been deleted
            {
                db.Products.Remove(item);

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex, cxt, IsEdit: false);
                }
                catch (Exception ex)
                {
                    HandleError(ex, cxt);
                }
            }
        }

        // Private helper methods
        private Product GetProductById(string id)
        {
            return (from p in db.Products
                    where p.ProductID == id
                    select p).FirstOrDefault();
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex,
            ModelMethodContext cxt, bool IsEdit)
        {
            ex.Entries.Single().Reload();
            if (IsEdit)
                cxt.ModelState.AddModelError("", "Another user changed that product. "
                + "Click Cancel to see changes.");
            else
                cxt.ModelState.AddModelError("", "Another user deleted that product.");
        }

        private void HandleValidationError(DbEntityValidationException ex,
            ModelMethodContext cxt)
        {
            foreach (var ve in ex.EntityValidationErrors) {
                foreach (var e in ve.ValidationErrors) {
                    cxt.ModelState.AddModelError("", $"Error: {e.ErrorMessage}");
                }
            }
        }

        private void HandleError(Exception ex,
            ModelMethodContext cxt)
        {
            cxt.ModelState.AddModelError("", 
                $"Database error: {GetExceptionMessages(ex)}");
        }

        private string GetExceptionMessages(Exception e)
        {
            if (e == null) return string.Empty;
            string msg = e.Message;
            // recursively call inner exceptions until you get to the last one
            if (e.InnerException != null)
                msg = GetExceptionMessages(e.InnerException);
            return msg;
        }

    }
}
