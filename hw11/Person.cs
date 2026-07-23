using System;
using System.Collections.Generic;
using System.Text;

namespace hw11
{
    public class Person
    {
        [MyProperty("Full Name")]
        public string Name { get; set; }

        [MyProperty("Age")]
        public int Age { get; set; }

        public string Password { get; set; }
    }
}
