using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3StudentChallenge.Class
{
    public partial class AudioBook : Book
    {

        private int duration;
        private String narrator;

        public int Duration
        {

            get { return duration; }
            set { duration = value; }

        }

        public String Narrator
        {

            get { return narrator; }
            set { narrator = value; }

        }
    }

}
