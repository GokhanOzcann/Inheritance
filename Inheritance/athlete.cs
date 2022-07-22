using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class athlete
    {
        private string name;
        private string surname;
        private int age;
        private string position;

        public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }
        public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); } 
        }
        public int AGE
        {
            get { return age; }
            set { age = Math.Abs(value); } 
        }
        public string POSITION
        {
            get { return position; }
            set { position = value.ToUpper(); }
        }
    }
}

