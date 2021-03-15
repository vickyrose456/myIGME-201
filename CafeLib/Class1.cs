using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Victoria Olivieri
//PE 16 - Classiest

namespace CafeLib
{
    //+IMood
    public interface IMood
    {

        //+Mood:string:r
        public string Mood
        {
            get
            {
                return "";
            }
        }
    }//IMood


    //+Customer
    public class Customer : HotDrink, IMood
    {
        //+name:string
        public string name;
        //+creditCardNum:string
        public string creditCardNumber;

        //Mood:String:r
        public string Mood
        {
            get 
            {
                return "";
            }
        }
    }//Customer

    public class Waiter : IMood 
    {
        //+name:string
        public string name;

        //+mood:string:r
        public string Mood
        {
            get 
            {
                return "";
            }
        }

        //+serveCust(cup:hotDrink):void
        public void ServeCustomer(HotDrink cup)
        {
            
        }

    }//Waiter



    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        //AddSugar(amount:byte):v
        public virtual int AddSugar(byte amount);

        //steam():a
        public abstract void Steam();

        //()
        public HotDrink() 
        {

        }

        //(brand:strng)
        public HotDrink(string brand)
        {
            
        }
        

    }//abstract hotDrink


    //+CupofCoffee
    public class CupOfCoffee : HotDrink
    {
        //beantype:string
        public string beanType;

        //+steam():o
        public override void Steam ()
        {

        }

        //+Takeorder()
        public void TakeOrder()
        {
            
        }

        //+brand:string):base(brand)
        public CupOfCoffee(string brand) : base(brand)
        {
            
        }

    }












}
