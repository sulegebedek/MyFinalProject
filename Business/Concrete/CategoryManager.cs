using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _cateoryDal;

        public CategoryManager(ICategoryDal cateoryDal)
        {
            _cateoryDal = cateoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _cateoryDal.GetAll();
        }
        //Select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            return _cateoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
