using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete

{
    public class Material:IEntity
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }
}
