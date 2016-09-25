using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class AttributeService
    {
        public AttributeService()
        {
            UseCustomAttribute();
        }

        private void UseCustomAttribute()
        {
            var mi = typeof(Classes);
            var customAttr = (CustomAttribute) Attribute.GetCustomAttribute(mi, typeof(CustomAttribute));

            if (typeof(Classes).IsDefined(typeof(CustomAttribute), false))
            {
                Console.WriteLine(typeof(CustomAttribute).Name + " is defined!");
            }

        }
    }
}
