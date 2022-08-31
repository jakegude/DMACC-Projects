using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ch24Service_WCF
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetCategories();

        [OperationContract]
        Category GetCategoryById(string id);

        [OperationContract]
        int InsertCategory(Category c);

        [OperationContract]
        int UpdateCategory(Category c);

        [OperationContract]
        int DeleteCategory(Category c);
    }

    [DataContract]
    public class Category
    {
        [DataMember]
        public string CategoryID { get; set; }

        [DataMember]
        public string ShortName { get; set; }

        [DataMember]
        public string LongName { get; set; }
    }
}
