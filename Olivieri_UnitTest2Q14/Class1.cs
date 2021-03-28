using System;

namespace Olivieri_UnitTest2Q14
{
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthday;
        public string address;

        public Friend()
        {
            this.name = "Charlie Sheen";
            this.greeting = "Dear Charlie";
            this.birthday = DateTime.Parse("1967-12-25");
            this.address = "123 Any Street, NY NY 12202";
        }
    }
    public class Enemy : Friend 
    {
        public Enemy()
        {
            this.greeting = "Sorry Charlie";
            this.address = "Return to sender. Address Unknown. ";
        }
    }

   

    /*

    struct Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend;
            Friend enemy;

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = friend;

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
    */
}
