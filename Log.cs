using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
    class Logger
    {
        public void Info() { }
        public void Debug() { }
        public void Warning() { }
        public void Error() { }

        public Logger(AddressBook ad) {
              ad.RaiseCustomEvent += HandleCustomEvent;
            }

         void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine( " received this message: {0}", e.Message);
        }

        public void Print_to_Console()
        {
            Console.WriteLine("Enter what you want console to print");
            string print = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Here you are {0}", print);
        }

        public void Print_to_File()
        {
            Console.WriteLine("Enter what you want  to print in file");
            string print = Convert.ToString(Console.ReadLine());
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("file.txt"))
            {
                
                    sw.WriteLine(print);
                sw.Close;
                
            }
        }
    }
}
