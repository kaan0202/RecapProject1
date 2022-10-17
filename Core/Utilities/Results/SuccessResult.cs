using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message,bool success) : base(message,true)
        {

        }
        public SuccessResult(bool success) : base(true)
        {

        }
    }
}
