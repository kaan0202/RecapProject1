using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private bool success;

       

        public Result(string message,bool success):this(success)
        {
           Messages= message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Messages { get; }
    }
}
