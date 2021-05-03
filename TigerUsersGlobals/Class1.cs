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
    
    public class Class1
    {
        //create new user
        public static People people = new People();

        //create some generic people
        public static void AddPeopleData()
        {
            int i = 0;
            Person person = null;

            Random rand = new Random();

            String[] userName = new string[] {"vro6068", "dao9631", "dxsigm", "aem3780", "tdd9179", "al3464"};

        }
    }
}
