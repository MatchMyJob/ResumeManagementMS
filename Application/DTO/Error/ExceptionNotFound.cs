﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Error
{
    public class ExceptionNotFound : Exception
    {
        public ExceptionNotFound(string message) : base(message)
        {
        }
    }
}
