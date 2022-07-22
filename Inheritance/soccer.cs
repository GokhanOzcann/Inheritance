using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class soccer : athlete
    {
        
            private string country;
            private string team;
            private string league;

            public string COUNTRY
            {
                get { return country; }
                set { country = value.ToUpper(); }
            }
            public string TEAM
            {
                get { return team; }
                set { team = value.ToUpper(); }
            }
            public string LEAGUE
            {
                get { return league; }
                set { league = value.ToUpper(); }
            }
        }
    }


