using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsDemo2
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();

            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name = "Mohamed",
                    Age = 34
                },
                new Person
                {
                    Name = "Houssem",
                    Age = 26
                },
                new Person
                {
                    Name = "Marwen",
                    Age = 26
                },
                new Person
                {
                    Name = "Othman",
                    Age = 26
                },
                new Person
                {
                    Name = "Hassen",
                    Age = 26
                },
            };
		}
	}
}
