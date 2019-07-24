using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Northwind.Entities.Concreate
{
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
