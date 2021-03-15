using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        //AddSugar(amount:byte):v
        public virtual int AddSugar(byte amount)
        {
            
        }

        //steam():a
        public abstract void Steam()
        {
            
        }

        //()
        public HotDrink() 
        {

        }

        //(brand:strng)
        public HotDrink(string brand)
        {
            
        }
        

    }//abstract hotDrink





}
