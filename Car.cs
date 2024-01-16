using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldsProperties_JuanHernandez
{
    internal class Car
    {
        private string _brand; // this is the make of a car, every car has a make
        // this is prive to prevent unwanted users have access to this information.

        // Public property for the _brand field with both getter and setter
        public string Brand
        {
            get { return _brand; } 
            set
            {
            
                if (!string.IsNullOrEmpty(value))
                    _brand = value;
                else
                    throw new ArgumentException("Name cannot be empty");
            }
        }
        // Encapsulation makes field eaiser to modify without affecting other parts.
        public string ReadOnlyBrand //only getter
        {
            get { return _brand; }
        }

        public string WriteOnlyBrand //only setter
        {
            set { _brand = value; }
        }
    }
}
