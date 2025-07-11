﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication
{
    public static class CommonOutputText
    {
        private static string MainHeading
        {
            get
            {
                string heading = "Calesthenics Club";
                return $"{heading}{Environment.NewLine}{new string('-',heading.Length)}";
            }
        }

        private static string RegistrationHeading
        {
            get
            {
                string heading = "Register";
                return $"{heading}{Environment.NewLine}{new string('-',heading.Length)}";
            }
        }

        private static string LoginHeading
        {
            get
            {
                string heading = "Login";
                return $"{heading}{Environment.NewLine}{new string('-',heading.Length)}";
            }
        }

        public static void WriteMainHeading()
        {
            Console.Clear();
            Console.WriteLine(MainHeading);
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void WriteLoginHeading()
        {
            Console.WriteLine(LoginHeading);
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void WriteRegistrationHeading()
        {
            Console.WriteLine(RegistrationHeading);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
