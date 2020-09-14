using DataLayer;
using Entity;
using System.Collections.Generic;

namespace BusinessLayer
{    
    public class CategoryBusiness
    {
        public CategoryData objCategoryData;
        public CategoryBusiness()
        {
            objCategoryData = new CategoryData();

        }
        public List<Category> GetAll()
        {
            return objCategoryData.GetAll();
        }

        public bool Save(Category objCategory)
        {
            if (objCategory.Id == 0)
                return objCategoryData.Insert(objCategory);
            else
                return objCategoryData.Update(objCategory);
        }
    }
}
