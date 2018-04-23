﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExerciseList
{
    public class SearchGroup : ObservableCollection<Search>
	{
		public string Title { get; set; }

		public SearchGroup(string title, IEnumerable<Search> searches = null)
			: base(searches)
		{
			Title = title;
		}
    }
}
