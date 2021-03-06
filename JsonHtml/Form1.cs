﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PeopleAppGlobals;
using PeopleLib;
using System.IO;
using System.Net;

namespace JsonHtml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Globals.AddPeopleSampleData();

            //serialized that sorted list.. Need to do student/teah indiv
            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();

            foreach (KeyValuePair<string, Person> keyValuePair in Globals.people.sortedList)
            {
                if (keyValuePair.Value.GetType() == typeof(Teacher))
                {
                    teachers.Add((Teacher)keyValuePair.Value);
                }
                else 
                {
                    students.Add((Student)keyValuePair.Value);
                }
            }

            //JSON will convert it to readible data
            string s = JsonConvert.SerializeObject(students);
            string t = JsonConvert.SerializeObject(teachers);

            //now write them to a file
            StreamWriter writer = new StreamWriter("c:/temp/student.json");
            writer.Write(s);

            writer = new StreamWriter("c:/temp/teacher.json");
            writer.Write(t);
            writer.Close();

            //read that data back in
            
            StreamReader reader = new StreamReader("c:/temp/student.json");
            s = reader.ReadToEnd();
            reader.Close();

            reader = new StreamReader("c:/temp/teacher.json");
            t = reader.ReadToEnd();
            reader.Close();

            //desrialize the data back into the list
                                                    //obj type <list type> (what we are deserializing)
            students = JsonConvert.DeserializeObject<List<Student>>(s);
            teachers = JsonConvert.DeserializeObject<List<Teacher>>(t);

            SortedList<string, Person> people = new SortedList<string, Person>();

            foreach(Student student in students)
            {
                people[student.email] = student;
            }

            foreach (Teacher teacher in teachers)
            {
                people[teacher.email] = teacher;
            }

            string url = "http://people.rit.edu/dxsigm/json.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //read from the socket
            reader = new StreamReader(response.GetResponseStream());

            t = reader.ReadToEnd();
            reader.Close();
            response.Close();

            //t has lis of teachers in serialized format from banjo site now ^^^

            teachers = JsonConvert.DeserializeObject<List<Teacher>>(t);

        }
    }
}
