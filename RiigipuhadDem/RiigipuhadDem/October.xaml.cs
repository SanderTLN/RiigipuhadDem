using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipuhadDem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class October : ContentPage
    {
        public October()
        {
            InitializeComponent();
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "October 2021", FontSize = 30 },
                new Rectangle(240, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Days in the month", FontSize = 25 },
                new Rectangle(30, 100, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "The calendar: 31 days", FontSize = 15 },
                new Rectangle(30, 150, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Working days: 21 days", FontSize = 15 },
                new Rectangle(30, 200, 200, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays: 10 days", FontSize = 15 },
                new Rectangle(30, 250, 230, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Weekends and holidays", FontSize = 25 },
                new Rectangle(380, 100, 280, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "There are no holidays in this month", FontSize = 15 },
                new Rectangle(380, 150, 280, 60)
            );
            Content = absoluteLayout;
        }
    }
}