using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class Applicant
    {
        public string _name { get; set; }
        public int _score { get; set; }
        public string _test { get; set; }

        public int Id { get; set; }
        //Validation for Attributes
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name should not be empty");
                _name = value;
            }
        }

        public int Score
        {
            get => _score;
            set
            {
                if (_score < 0)
                    throw new Exception("Score should not be less than zero");
                _score = value;
            }
        }

        public string Test
        {
            get => _test;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Test should not be empty");
                _test = value;
            }
        }

        public Applicant()
        {

        }
        //Constructor
        public Applicant(string name, int score, string test)
        {
            Name = name;
            Score = score;
            Test = test;
        }
    }
}