﻿using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Views
{
    public class WelcomeUserView : IView
    {
        User _user = null;

        public WelcomeUserView(User user)
        {
            _user = user;
        }
        public IFieldValidator FieldValidator => null;

        public void RunView()
        {
            Console.Clear();
            CommonOutputText.WriteMainHeading();

            CommonOutputFormat.ChangeFontColor(FontTheme.Success);
            Console.WriteLine($"Hi {_user.FirstName} {_user.LastName}!!{Environment.NewLine}Welcome to the Calesthenics Club!!");
            CommonOutputFormat.ChangeFontColor(FontTheme.Default);
            Console.ReadKey();
        }
    }
}
