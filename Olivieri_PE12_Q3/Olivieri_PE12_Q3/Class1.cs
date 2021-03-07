using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE12_Q3
{
    public abstract class MyClass
    {
        private string myString;

        public string MyString
        {
            set
            {
                myString = value;
            }
        }//myString

        public virtual string GetString()
        {
            return myString;
        }
    }//end my class

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + "output from derived class";
        }
    }
    
}//end namespace

