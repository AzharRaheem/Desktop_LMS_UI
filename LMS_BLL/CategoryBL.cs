using LMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DomainModel;

namespace LMS_BLL
{
    public class CategoryBL
    {
        CategoryRepo categoryRepo;
        public CategoryBL()
        {
            categoryRepo = new CategoryRepo();
        }

        public BaseViewModel saveCategory(Category category)
        {
            return categoryRepo.saveCategoryInDB(category);
        }

        public CategoryStatusBaseVM getAllCategories()
        {
            return categoryRepo.getAllCategoriesFromDB();
        }

        public CategoryStatusBaseVM getFilteredCategories(string text)
        {
            return categoryRepo.getFilteredCategoriesFromDB(text);
        }

        public BaseViewModel deleteCategory(int cat_id)
        {
            return categoryRepo.deleteCategoryFromDB(cat_id);
        }

        public BaseViewModel updateCategory(Category cat)
        {
            return categoryRepo.updateCategroyInDB(cat);
        }
    }
    
}
