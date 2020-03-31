using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Utils.Utils
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyTargetAttribute : Attribute
    {
        public readonly string PropertyName;
        public PropertyTargetAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }

    }
}
