using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataAgendamento { get; set; } = DateTime.Now;
        public TimeSpan HoraAgendamento { get; set; }


        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            // this.Title = $"{this.Title}: {veiculo.Name}";
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", $"Cliente {Nome} agendamento com sucesso!", "OK");
        }
    }
}