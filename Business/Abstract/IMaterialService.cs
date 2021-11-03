using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMaterialService
    {
        IResult Add(Material material);
        IResult Delete(Material material);
        IResult Update(Material material);
        IDataResult<List<Material>> GetAll();
        IDataResult<Material> GetById(int materialId);
    }
}
