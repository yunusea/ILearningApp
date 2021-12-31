﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Application.Dto
{
    public class ProductGetByIdViewDto
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string ProductName { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
