﻿using System.Collections.Generic;
using Xamarin.Forms;

namespace ExerciseNavigation
{
    public partial class ExerciseNavigationPage : TabbedPage
    {

		//private List<User> UserData = new List<User>
			//{
			//	new User { Id = 0, Name = "Shinji Nakai", Description = "My name is Shinji." },
			//	new User { Id = 1, Name = "Jenny Daiby", Description = "My name is Jenny Daiby." },
			//	new User { Id = 2, Name = "Jonv", Description = "My name is Jonv." },
			//	new User { Id = 3, Name = "RacheMartin", Description = "My name is RacheMartin." },
			//	new User { Id = 4, Name = "Bivan Jay", Description = "My name is Bivan Jay." },
			//	new User { Id = 5, Name = "SanaZ", Description = "My name is SanaZ." },
			//	new User { Id = 6, Name = "NextLab", Description = "My name is NextLab." },
			//	new User { Id = 7, Name = "Alex B", Description = "My name is Alex B." },
			//	new User { Id = 8, Name = "Tara Chang", Description = "My name is Tara Chang." },
			//	new User { Id = 9, Name = "Tom K", Description = "My name is Tom K." }
			//};

        public ExerciseNavigationPage()
        {
			InitializeComponent();

			this.Children.Add(new ExerciseNavigation.FeedPage());

            this.Children.Add(new ExerciseNavigation.UserProfilePage(0));
		}
		

    }
}
