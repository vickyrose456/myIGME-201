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

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; i++)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            //Continue coding trivia app:
            int userAnswer = 0;
            int numOfAnswers = trivia.results[0].incorrect_answers.Count;
            string[] myAnswers = new string[numOfAnswers + 1];

            //Console.WriteLine(trivia.results[0].incorrect_answers.Count + 1);
            //show question
            Console.WriteLine(trivia.results[0].question);

            //show incorrect and correct answers

            //get all answers and store them into an array of answers
            for (int i = 0; i < numOfAnswers; i++)
            {
                //store incorrect answers in array
                myAnswers[i] = trivia.results[0].incorrect_answers[i];
            }
            //store the correct answer at the final index
            myAnswers[numOfAnswers] = trivia.results[0].correct_answer;

            //print out the answers randomly
            Randomize<string>(myAnswers);

            for (int i = 0; i < myAnswers.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + myAnswers[i]);
            }

            //prompt user for reponse
            Console.WriteLine("Enter the number of your choice: ");

            //read response
            try
            {
                userAnswer = int.Parse(Console.ReadLine());
                userAnswer = userAnswer - 1;
                if (userAnswer >= numOfAnswers)
                {
                    Console.WriteLine("Not a valid choice. \nEnter the number of your choice: ");
                    userAnswer = int.Parse(Console.ReadLine());
                    userAnswer = userAnswer - 1;
                }
            }
            catch
            {
                Console.WriteLine("Not a valid integer. \nEnter the number of your choice: ");
                userAnswer = int.Parse(Console.ReadLine());
            }


            //if the repsonse it correct congrats, if not sorry
            if (myAnswers[userAnswer] == trivia.results[0].correct_answer)
            {
                Console.WriteLine("Nice! That is correct.");
            }
            else {
                Console.WriteLine("Sorry, that was incorrect. ");

            }
            
        }
        /*
         * Randomize will swap the positions of the array randomly
         */
        public static void Randomize<Ans>(Ans[] items)
        {
            Random rand = new Random();

            for (int i = 0; i < items.Length - 1; i++)
            {
                int q = rand.Next(i, items.Length);
                Ans temp = items[i];
                items[i] = items[q];
                items[q] = temp;
            }
        }
    }
    }
    
