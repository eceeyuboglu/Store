using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
