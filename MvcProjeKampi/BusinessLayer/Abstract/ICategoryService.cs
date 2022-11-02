using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface ICategoryService
    {

        Category GetById(int id);
        List<Category> GetList();
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
        void CategoryAdd(Category category);
    }
}
