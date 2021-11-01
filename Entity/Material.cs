using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Material:IEntity
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }
}
