using System;
using StadiumApi.Models.Enums;

namespace StadiumApi.Models
{
	public class Visitor
	{
		public string? Name { get; set; }

		public string? Surname { get; set; }

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

		public Sex Sex { get; set; }

        public string? Address { get; set; }

		public string? PhoneNumber { get; set; }

		public string? Email { get; set; }
    }
}