using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomAttribute : Attribute
    {
        private int _counter;
        private string _description;
        public CustomAttribute(int counter)
        {
            this._counter = counter;
        }

        public string Description 
        { 
            get 
            { 
                return this._description; 
            } 

            set 
            { 
                this._description = value; 
            } 
        }
    }


}
