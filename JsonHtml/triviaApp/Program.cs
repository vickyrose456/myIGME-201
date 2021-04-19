using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

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
        public List<TriviaResult> results;

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            //rends request to the url
            response = (HttpWebResponse)request.GetResponse();

            reader = new StreamReader(response.GetResponseStream());

            s = reader.ReadToEnd();
            reader.Close();

            //deserialize into trivia obj
            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i=0; i< trivia.results[0].incorrect_answers.Count; i++)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            //Continue coding trivia app:
            string userAnswer = null;
            string [] myAnswers = new string[trivia.results[0].incorrect_answers.Count + 1];

            //Console.WriteLine(trivia.results[0].incorrect_answers.Count + 1);
            //show question
            Console.WriteLine(trivia.results[0].question);

            //show incorrect and correct answers

            //get all answers and store them into an array of answers
            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; i++)
            {
                //store incorrect answers in array
                myAnswers[i] = trivia.results[0].incorrect_answers[i];
            }
            //store the correct answer at the final index
            myAnswers[trivia.results[0].incorrect_answers.Count] = trivia.results[0].correct_answer; 

            //print out the answers randomly
            for (int i = 0; i< myAnswers.Length; i++)
            {
               Console.WriteLine((i + 1) + ". " + myAnswers[i]);
            }


            //prompt user for reponse
            Console.WriteLine("Enter the number of your choice: ");
            //read response
            userAnswer = Console.ReadLine();

        }
    }
}
