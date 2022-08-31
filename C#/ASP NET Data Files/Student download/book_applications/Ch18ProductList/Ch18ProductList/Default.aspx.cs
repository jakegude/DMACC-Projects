using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// make sure to include these using directives
using Ch18ProductList.Models;
using System.Web.ModelBinding;

namespace Ch18ProductList
{
    public partial class Default : System.Web.UI.Page
    {
        HalloweenEntities db = new HalloweenEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<Category> ddlCategory_GetData()
        {
            return from c in db.Categories
                   orderby c.LongName
                   select c;
        }

        public IQueryable<Product> grdProducts_GetData([Control] string ddlCategory)
        {
            // get first category ID from database if nothing is passed in 
            if (ddlCategory == null)
                ddlCategory = (from c in db.Categories
                               orderby c.LongName
                               select c).FirstOrDefault().CategoryID;

            // get the products for the selected category
            return from p in db.Products
                   where p.CategoryID == ddlCategory
                   orderby p.Name
                   select p;
        }

        protected void grdProducts_PreRender(object sender, EventArgs e)
        {
            grdProducts.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}