using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    // busines içindeki abstract interfaceler service olarak
    // business içindeli concrete deki classlarda manager olarak adlandırılır
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
          _categoryDal.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
           _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
           return  _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
