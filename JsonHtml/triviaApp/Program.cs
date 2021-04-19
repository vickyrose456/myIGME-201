using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace triviaApp
{
    class TriviaResult
    {
        //need to have the SAME NAME is JSON
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;

        //the deserializer will instantiate it
    }
    class Trivia
    {
        public int response_code;
        //list of results
        public List<TriviaResult> TriviaResult;

    }
   
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
