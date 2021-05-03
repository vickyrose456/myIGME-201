using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TigerChatPeopleLib;

namespace TigerUsersGlobals
{

    public interface IListView
    {
        void PaintListView(string code);
    }
    
    public class Globals
    {
        //create new user
        public static People people = new People();

        //create some generic people
        public static void AddPeopleData()
        {
            int i = 0;
            Person person = null;
            User user = null;

            Random rand = new Random();

            String[] userNames = new string[] {"vro6068", "dao9631", "dxsigm", "aem3780", "tdd9179", "al3464"};
            //String[] firstName = new string[] { "Victoria", "Dennis", "David", "Allie", "Twanda", "Archer"};
            //String[] lastName = new string[] { "Olivieri", "O", "Schuh", "M", "D", "L"};

            for (i = 0; i < 10; i++)
            {
                user = new User();

                person = user;

                //use the username list to assign that to the username
                person.email = "person_" + i.ToString() + "@rit.edu";
                person.userName = userNames[rand.Next(0, userNames.Length)];

                people[person.email] = person;
            }
        }
    }
}
