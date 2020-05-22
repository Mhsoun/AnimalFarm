using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Chicken
    {
        
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => name;
            set
            {
                if (NotNullNotEmptuNotWhiteSpace(name))
                {
                    name = value;
                }
                else
                {
                    throw new System.ArgumentException("name not valid");
                }
            }
        }

        public int Age
        {
            get => age;
            set
            {

                if (value < 0 || value > 15)
                {
                    throw new System.ArgumentException("age should be between 0 and 15");
                }
                this.age = value;
            }
        }

        public int ProductPerDay { 
            get { return CalculateProductPerDay(age); }}

        private bool NotNullNotEmptuNotWhiteSpace(string toValidate)
        {
            return string.IsNullOrEmpty(toValidate) & string.IsNullOrWhiteSpace(toValidate);
        }

        private int CalculateProductPerDay(int chickenAge)
        {
            if (chickenAge < 1)
            {
                Console.WriteLine("chicken doesn't produce any ages at this age");
                return 0;
            } else if(chickenAge>1 && chickenAge<10)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }


    }
}
