using System;
using System.Collections.Generic;
using System.Text;

namespace hw11
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyPropertyAttribute : Attribute
    {
        public string Name { get; set; }

        public MyPropertyAttribute(string name)
        {
            Name = name;
        }
    }
}
