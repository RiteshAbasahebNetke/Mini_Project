﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_Project.Models
{
    public class CheckBoxVM
    {
        public Int64? Value { get; set; }
        public string Text { get; set; }
        public bool IsSelected { get; set; }
    }
}