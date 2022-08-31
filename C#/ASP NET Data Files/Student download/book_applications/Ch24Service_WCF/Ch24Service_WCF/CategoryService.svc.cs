using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ch24Service_WCF
{
    public class CategoryService : ICategoryService
    {
        private CategoryDB data;
        public CategoryService()
        {
            data = new CategoryDB();
        }

        public List<Category> GetCategories()
        {
            return data.GetCategories();
        }

        public Category GetCategoryById(string id)
        {
            return data.GetCategoryById(id);
        }

        public int InsertCategory(Category c)
        {
            try
            {
                return data.InsertCategory(c);
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateCategory(Category c)
        {
            return data.UpdateCategory(c);
        }

        public int DeleteCategory(Category c)
        {
            return data.DeleteCategory(c);
        }
    }
}
