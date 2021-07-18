using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DomainModel;

namespace LMS_DAL
{
    public class CategoryRepo
    {
        LMSDbContext db;
        public CategoryRepo()
        {
            db = new LMSDbContext();
        }

        public BaseViewModel saveCategoryInDB(Category category)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.Categories.Add(category);
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.isSuccess = true;
                    result.message = "Category Added Successfully.";
                }
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
                result.data = null;
            }
            return result;
        }

        public BaseViewModel updateCategroyInDB(Category cat)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var category = db.Categories.Where(c => c.id == cat.id).FirstOrDefault();
                category.name = cat.name;
                category.status = cat.status;
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.isSuccess = true;
                    result.message = "Category Updated Successfully.";
                }                
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
                result.data = null;
            }
            return result;
        }

        public BaseViewModel deleteCategoryFromDB(int cat_id)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
               
                var category = db.Categories.Where(c => c.id == cat_id).First();
                db.Categories.Remove(category);
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.message = "Category Deleted Successfully.";
                    result.isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
                result.data = null;
            }
            return result;
        }

        public CategoryStatusBaseVM getFilteredCategoriesFromDB(string text)
        {
            CategoryStatusBaseVM result = new CategoryStatusBaseVM();
            List<Category> categories = new List<Category>();
            try
            {
                categories = db.Categories.Where(c => c.name.ToLower().Contains(text.ToLower())).ToList();
                result.isSuccess = true;
                result.categories = new List<CategoryStatusVM>();
                foreach (var category in categories)
                {
                    CategoryStatusVM categoryVM = new CategoryStatusVM();
                    categoryVM.id = category.id;
                    categoryVM.name = category.name;
                    categoryVM.statusIndex = category.status;
                    if (category.status == 1)
                    {
                        categoryVM.statusValue = "Active";
                    }
                    else
                    {
                        categoryVM.statusValue = "In-Active";
                    }
                    result.categories.Add(categoryVM);
                }
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public CategoryStatusBaseVM getAllCategoriesFromDB()
        {
            CategoryStatusBaseVM result = new CategoryStatusBaseVM();
            List<Category> categories = new List<Category>();
            try
            {
                categories = db.Categories.ToList();
                result.isSuccess = true;
                result.categories = new List<CategoryStatusVM>();
                foreach (var category in categories)
                {
                    CategoryStatusVM categoryVM = new CategoryStatusVM();
                    categoryVM.id = category.id;
                    categoryVM.name = category.name;
                    categoryVM.statusIndex = category.status;
                    if(category.status == 1)
                    {
                        categoryVM.statusValue = "Active";
                    }
                    else
                    {
                        categoryVM.statusValue = "In-Active";
                    }
                    result.categories.Add(categoryVM);
                }
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }
    }
}
