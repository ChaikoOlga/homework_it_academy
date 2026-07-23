using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace hw11
{
    public class MySerializer
    {
        public string Serialize(object obj)
        {
            StringBuilder builder = new StringBuilder();

            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                MyPropertyAttribute attribute =
                    property.GetCustomAttribute<MyPropertyAttribute>();

                if (attribute != null)
                {
                    builder.AppendLine(
                        attribute.Name + ": " + property.GetValue(obj));
                }
            }

            return builder.ToString();
        }
    }
}
