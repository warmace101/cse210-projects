using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning04
{
    public class Assignment
    {
        private string _studentName = "";
        private string _topic = "";


        public void SetStudentName(string student)
        {
            _studentName = student;
        }

        public void SetTopic(string topic)
        {
            _topic = topic;
        }

        public string GetSummary()
        {
            return $"Student Name: {_studentName}, Topic: {_topic}";
        }
    }
}
