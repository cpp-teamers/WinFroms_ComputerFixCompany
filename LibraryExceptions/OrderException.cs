﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExceptions
{
    public class OrderException : BaseException
    {
        public OrderException(string message, string parametr) : base(message, parametr)
        { }
    }
}
