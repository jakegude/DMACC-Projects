using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch18ProductMaintenance
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Control_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject =
                new Ch18ProductMaintenance.Models.ProductDB();
        }

        // update gridview after delete, insert, or update
        protected void dvProduct_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            grdProducts.DataBind();
        }

        protected void dvProduct_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            grdProducts.DataBind();
        }

        protected void dvProduct_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            grdProducts.DataBind();
        }

        // needed for Bootstrap
        protected void grdProducts_PreRender(object sender, EventArgs e)
        {
            grdProducts.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}