using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }

        public void BlogAdd(Blog blog)
        {
           throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            _blogdal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogdal.Update(blog);
        }

        public List<Blog> GetBlockWithCategory()
        {
            return _blogdal.GetListViewCategory();
        }
        public List<Blog> GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogdal.GetListAll(x => x.WriterId == id);
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogdal.GetListWithCategoryByWriter(id);
        }
        public Blog TGetById(int id)
        {
            return _blogdal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            // take parametre de belitirilen kadar kayıt getirir
            return _blogdal.GetListAll().Take(3).ToList();
         }

        public void TAdd(Blog t)
        {
            _blogdal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogdal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogdal.Update(t);
        }
    }
}