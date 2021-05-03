using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerChatPeopleLib
{
    public enum genderPronoun
    {
        him,
        her,
        them
    }

    public abstract class Person
    {
        public string userName;
        //user email address
        public string email;
        //for the user photo
        public string photoPath;
        //the user's password
        private string userPassword;
        //bool for if the user wants to change password
        public bool resetPassword;
        //gender pronoun
        public genderPronoun userGender;
        //the user's b-day
        public DateTime dateOfBirth;
        public string UserPassword 
        {
            get 
            {
                return userPassword;
            }
            set 
            {
                //set the password if the user clicks "reset password"
                if (resetPassword == true)
                {
                    userPassword = value;
                }
            }
        }

    }//public class person 

    public interface IUser
    {
        void Settings();
    }


    public class User : Person
    {
        public List<String> friendsNames = new List<string>();

        public List<String> FriendsList
        {
            get 
            {
                return this.friendsNames;
            }
            set 
            {
                this.friendsNames = value;
            }
        }
    }


    public class People
    {
        //store people objects into the sorted list, want person object and password
        public SortedList<string,  Person> myList = new SortedList<string, Person>();
        
        public void Remove(string name)
        {
            if (name != null)
            {
                myList.Remove(name);
            }
        }

        public Person this[string userName]
        {
            get 
            {
                Person returnVal;
                try
                {
                    returnVal = (Person)myList[userName];
                }
                catch 
                {
                    returnVal = null;
                }
                return (returnVal);
            }
            set 
            {
                try
                {
                    //add to the list
                    myList.Add(userName, value);
                }
                catch {//duplicate handling 
                }
            }
        }
    }
}
