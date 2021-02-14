using System;
using System.IO;

namespace FunctionsEnumStruct
{
    enum GenderPronoun //: int is the default
    {
        him, //this is 0
        her, //1
        them //2 and so on
    }

    enum CollegeYear : byte
    {
        //can override the info here
        freshman = 24,
        sophomore = 23,
        junior = 22,
        senior = 21
    }

    struct StudentStruct
    {
        // member variables with defined accessibility
        public CollegeYear eCollegeYear;
        public GenderPronoun eGender;
        public string sName;
        public double grade;
        private string password; //only be accessible from within the structure

        // member property for accessing the private password field
        //a property is a smart field. A field that could contain its own logic.
        //we want something to be able to access the password
        //this is a property 
        //you can have get fns or set fns w/in a property 
        public string Password
        {
            get
            {
                return decrypt(this.password);
            }

            set
            {
                this.password = encrypt(value);
            }
        }

        private string decrypt(string password)
        {
            string decryptedValue = "";
            char[] cPassword;

            cPassword = password.ToCharArray();
            foreach (char c in cPassword)
            {
                decryptedValue += (c + 1);
            }

            return decryptedValue;
        }

        private string encrypt(string password)
        {
            string encryptedValue = "";
            char[] cPassword;

            cPassword = password.ToCharArray();
            foreach (char c in cPassword)
            {
                encryptedValue += (c - 1);
            }

            return encryptedValue;
        }
    }

    struct CourseStruct
    {
        public string courseCode;
        public StudentStruct[] students;

        public CourseStruct(string szCourseCode, StudentStruct[] students)
        {
            this.courseCode = szCourseCode;
            this.students = students;
        }

        public void AddStudent(StudentStruct student)
        {
            StudentStruct[] s;
            int newLength;
            int i = 0;

            // if the students array has not been created yet, set the new length to 1,
            // otherwise newLength should be 1 + the current Length (to hold the new student we are adding)
            newLength = (this.students == null) ? 1 : (this.students.Length + 1);

            // create the array of the new length
            s = new StudentStruct[newLength];

            // if the students array has existing values in it
            if (this.students != null)
            {
                // copy them into our new array
                foreach (StudentStruct st in this.students)
                {
                    s[i] = st;
                    ++i;
                }
            }

            // append our new student to the new array
            s[i] = student;

            // set our students array to point to the new array
            this.students = s;
        }
    }


    static class Examples
    {
        // Class Examples
        // Author: David Schuh
        // Purpose: Contains examples for Week 3
        // Restrictions: Only contains code snippets.  

        static void Main(string[] args)
        {
            // Method: Main
            // Purpose: The main entry point for the executable. Code snippet examples.
            // Restrictions: None

            ///////////////////////////////////////////////////////
            // Functions
            ///////////////////////////////////////////////////////
            {
                for (int i = 0; i < 10; ++i)
                {
                    Console.WriteLine($"{i} is " + (isEven(i) ? "even" : "odd"));
                }

                Console.WriteLine(CalcAverage(true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
                Console.WriteLine(CalcAverage(true, 1, 2));

                int one = 0;
                int two;

                // function overloading and passing variables by value or by reference
                SetOne(one);
                SetOne(ref one);

                SetTwo(out two);

                // the TryParse() method!
                string sNumber = null;
                int nNumber;
                do
                {
                    Console.Write("Enter a number: ");
                    sNumber = Console.ReadLine();
                } while (!int.TryParse(sNumber, out nNumber));
            }


            ///////////////////////////////////////////////////////
            // Structs
            ///////////////////////////////////////////////////////
            {
                StudentStruct[] students = new StudentStruct[2];

                students[0].eGender = GenderPronoun.her;
                students[0].eCollegeYear = CollegeYear.freshman;
                students[0].sName = "June Smith";
                students[0].grade = 56.9;
                students[0].Password = "pass1234"; //this will call the set  of password property
                
                students[1].eGender = GenderPronoun.them;
                students[1].eCollegeYear = CollegeYear.junior;
                students[1].sName = "Jan Smith";
                students[1].grade = 99.9;

                //this will use the English definition here in the foreach loop
                foreach (StudentStruct student in students)
                {
                    Console.WriteLine($"{student.sName} | {student.eCollegeYear} | {student.eGender} | {student.grade}");
                }
            }
        }

        static bool IsEven(int nTest)
        {
            // returns whether nTest is odd or even
            bool returnVal;

            // we could execute multiple returns, 
            // but having 1 return value and 1 return statement at the end is much clearer

            if (nTest % 2 == 0)
            {
                returnVal = true;
                //return (true);
            }
            else
            {
                returnVal = false;
                //return (false);
            }

            return (returnVal);
        }


        static double CalcAverage(bool skew, params int[] intArray)
        {
            // calculates the average of a list of ints
            // if skew is true, add 1 to each number
            double returnVal = 0;

            foreach (int thisInt in intArray)
            {
                returnVal += (thisInt + (skew ? 1 : 0));
            }

            returnVal /= intArray.Length;

            return (returnVal);
        }

        static void SetOne(int val)
        {
            val = 1;
        }

        static void SetOne(ref int val)
        {
            val = 1;
        }

        static void SetTwo(out int val)
        {
            val = 2;
        }
    }
}

