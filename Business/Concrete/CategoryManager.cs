using Business.Abstract;
using Core.Utilities.Results;
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

        public IDataResult<List<Category>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Category>>(_cateoryDal.GetAll());
        }
        //Select * from Categories where CategoryId = 3
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_cateoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
