﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Error
{
    public class ExceptionSintaxError : Exception
    {
        public ExceptionSintaxError(string message) : base(message)
        {
        }
    }
}
