﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuService.Models
{
    public class MenuItem
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public Boolean FreeDelivery { get; set; }

        public double Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfLaunch { get; set; }
        public Boolean Active { get; set; }
        public string CategoryName { get; set; }
    }
}
