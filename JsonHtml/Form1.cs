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

        }
    }
}
