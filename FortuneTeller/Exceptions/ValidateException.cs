﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller.Exceptions
{
    public class ValidateException : Exception
    {
        public ValidateException(string message) : base(message) { }
    }
}
