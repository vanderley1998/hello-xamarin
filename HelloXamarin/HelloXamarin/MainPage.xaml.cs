using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listViewVeiculos.ItemsSource = new string[]
            {
                "Azera V6",
                "Fiesta 2.0",
                "HB20S"
            }; 
        }
    }
}
