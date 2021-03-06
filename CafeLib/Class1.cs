﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Victoria Olivieri
//PE 16 - Classiest

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
            return this.sugar;
        }

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




    //+IMood
    public interface IMood
    {

        //+Mood:string:r
        string Mood { get; }
        
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

        public override void Steam()
        {
            
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



    


    //+CupofCoffee
    public class CupOfCoffee : HotDrink, ITakeOrder
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

    }//CupOfCoffee

    //+CupOfTea
    public class CupOfTea : HotDrink, ITakeOrder
    {
        //+leafType: String
        public string leafType;

        //+Steam():o
        public override void Steam()
        {
            
        }

        //+TakeOrder()
        public void TakeOrder()
        {

        }

        //+(customerIsWealthy:bool)
        public CupOfTea(bool customerIsWealthy)
        {
            
        }

    }//cup of tea

    public interface ITakeOrder
    {
        //+TakeOrder():void
        void TakeOrder();
    }//ITakeOrder interface 


    //+CupOfCocoa
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        //+numCups:int:s
        public static int numCups;
        //+marsh:bool
        public bool marshmallows;
        //-source:string
        private string source;

        //+Source:string:w
        public string Source 
        {
            get 
            {
                return this.source;
            }
        }

        //+Steam():o
        public override void Steam()
        {
            
        }

        //+AddSugar(amount:byte):o
        public override int AddSugar(byte amount)
        {
            return base.AddSugar(amount);
        }

        //+Takeorder()
        public void TakeOrder()
        {
            
        }

        //():this(false
        CupOfCocoa this[bool marshmallows] 
        {
            get { }
            set { }
        }

        CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
            
        }

    }//cupofCocoa

    



}
