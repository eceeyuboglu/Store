using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        IMaterialDal _materialDal;

        public MaterialManager(IMaterialDal materialDal)
        {
            _materialDal = materialDal;
        }
        public IResult Add(Material material)
        {
            _materialDal.Add(material);
            return new SuccessResult(Messages.MaterialAdded);
        }

        public IResult Delete(Material material)
        {
            _materialDal.Delete(material);
            return new SuccessResult(Messages.MaterialDeleted);
        }

        public IDataResult<List<Material>> GetAll()
        {
            var result = _materialDal.GetAll();
            return new SuccessDataResult<List<Material>>(result, Messages.MaterialListed);
        }

        public IDataResult<Material> GetById(int materialId)
        {
            var result = _materialDal.Get(m => m.MaterialId == materialId);
            return new SuccessDataResult<Material>(result);
        }

        public IResult Update(Material material)
        {
            _materialDal.Update(material);
            return new SuccessResult(Messages.MaterialUpdated);
        }
    }
}
