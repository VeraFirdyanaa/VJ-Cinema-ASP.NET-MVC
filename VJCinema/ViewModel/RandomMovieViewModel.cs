﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VJCinema.Models;

namespace VJCinema.ViewModel
{
	public class RandomMovieViewModel
	{
		public Movie Movie { get; set; }
		public List<Customer> Customers { get; set; }
	}
}