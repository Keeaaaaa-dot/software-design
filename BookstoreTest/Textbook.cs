using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    public class Textbook : Book 
    {
        public string Subject { get; set; } 

        public override string GetInfo()
        {
            return $"{base.GetInfo()} on subject '{Subject}'";
        }

        internal class AudioBook : Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Duration { get; set; }
            public string Narrator { get; set; }
        }
    }
}
