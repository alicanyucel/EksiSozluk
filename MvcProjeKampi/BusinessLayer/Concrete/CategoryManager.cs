using BusinessLayer.Abstract;
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
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
           return  efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
