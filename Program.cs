﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
        
                 

          AddressBook ab = new AddressBook();
            Logger l = new Logger(ab);
            ab.Adduser();
            ab.RemoveUser();



            Console.ReadKey();

        }
    }
}