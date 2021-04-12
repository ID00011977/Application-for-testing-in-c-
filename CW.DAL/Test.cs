using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class Test
    {
        public int Id { get; set; }

        private string name;
        private string Q1;
        private string answer1;
        private string Q2;
        private string answer2;
        private string Q3;
        private string answer3;



        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }

        public string Quest1
        {
            get => Q1;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please insert question 1");
                Q1 = value;
            }
        }

        public string Answer1
        {
            get => answer1;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please insert answer for question 1");
                answer1 = value;
            }
        }

        public string Quest2
        {
            get => Q2;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please insert question 2");
                Q2 = value;
            }
        }

        public string Answer2
        {
            get => answer2;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please insert answer for question 2");
                answer2 = value;
            }
        }

        public string Quest3
        {
            get => Q3;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please insert question 3");
                Q3 = value;
            }
        }

        public string Answer3
        {
            get =>  answer3;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please insert answer for question 3");
                answer3 = value;
            }
        }



        public Test()
        {

        }

        public Test(string name, string ques1, string ques1_answer, string ques2, string ques2_answer, string ques3, string ques3_answer)
        {
            Name = name;
            Q1 = ques1;
            answer1 = ques1_answer;
            Q2 = ques2;
            answer2 = ques2_answer;
            Q3 = ques3;
            answer3 = ques3_answer;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
