﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Product> Products { get; set; }
    }
}
