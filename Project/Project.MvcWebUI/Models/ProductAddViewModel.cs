﻿using Project.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
      public  List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
