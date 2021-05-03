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
        public static Person person = new Person();

        //create some generic people
        public static void AddPeopleData()
        {
            int i = 0;
            Person person = null;
        }
    }
}
