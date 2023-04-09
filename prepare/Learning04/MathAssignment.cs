using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning04
{
    public class MathAssignment : Assignment
    {
        private string _textBook = "";
        private string _problem = "";


        public void SetTextBook(string textbook)
        {
            _textBook = textbook;
        }

        public void SetProblem(string problem)
        {
            _problem = problem;
        }

        public string GetHomeworkList()
        {
            return $"Use the {_textBook} for problem {_problem}";

        }
    }
}
