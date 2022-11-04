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
            
        }

        public void BlogDelete(Blog blog)
        {
           
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlockWithCategory()
        {
            return _blogdal.GetListViewCategory();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogdal.GetListAll(x => x.BlogId == id);
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }
    }
}