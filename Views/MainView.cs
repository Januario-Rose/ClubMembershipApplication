﻿using ClubMembershipApplication.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Views
{
    internal class MainView : IView
    {
        public IFieldValidator FieldValidator => null;

        IView _registerView = null;
        IView _loginView = null;

        public MainView(IView registerView, IView loginView)
        {
            _registerView = registerView;
            _loginView = loginView;
        }

        public void RunView()
        {
            CommonOutputText.WriteMainHeading();

            Console.WriteLine("Please press 'L' to login or if you are not yet registered please press 'R'");

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.R:
                    RunUserRegistrationView();
                    RunLoginView();
                    break;
                case ConsoleKey.L:
                    RunLoginView();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    Console.ReadKey();
                    break;
            }
        }

        private void RunUserRegistrationView()
        {
            _registerView.RunView();
        }

        private void RunLoginView()
        {
            _loginView.RunView();
        }
    }
}
