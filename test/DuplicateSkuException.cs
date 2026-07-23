using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class DuplicateSkuException : Exception
    {
        public DuplicateSkuException(string message) : base(message)
        {

        }
    }
}
