﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(bool success,string message):base(message,false)
        {

        }
        public ErrorResult(bool success):base(false)
        {

        }
    }
}
