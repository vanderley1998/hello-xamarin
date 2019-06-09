using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin.Views
{
    public class Veiculo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string FormattedPrice { get { return string.Format("R$ {0}", Price); } }
    }

    public partial class ListagemView : ContentPage
    {

        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Name = "Azera v6", Price = 60000},
                new Veiculo { Name = "Fiesta 2.0", Price = 34000},
                new Veiculo { Name = "HB20S", Price = 25000}
            };

            // listViewVeiculos.ItemsSource = this.Veiculos; --> taguiado na view
            this.BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo) e.Item;
            // DisplayAlert("Test drive", string.Format("Você tocou no modelo '{0}', que custa {1}", veiculo.Name, veiculo.FormattedPrice), "OK");
            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}
