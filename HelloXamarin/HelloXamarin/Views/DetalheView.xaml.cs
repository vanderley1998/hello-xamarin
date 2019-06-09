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
    public partial class DetalheView : ContentPage
    {
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public Veiculo Veiculo { get; set; }

        public string TextFreioABS { get { return string.Format("Freio ABS - R${0}", FREIO_ABS); } }
        public string TextArCondicionado { get { return string.Format("Ar Condicionado - R${0}", AR_CONDICIONADO); } }
        public string TextMP3Player { get { return string.Format("MP3 Player - R${0}", MP3_PLAYER); } }

        private bool _temFreioABS;
        public bool TemFreioABS
        {
            get { return this._temFreioABS; }
            set
            {
                this._temFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool _temArCondicionado;
        public bool TemArCondicionado
        {
            get { return _temArCondicionado; }
            set
            {
                this._temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool _temMP3Player;
        public bool TemMP3Player
        {
            get { return _temMP3Player; }
            set
            {
                this._temMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R${0}", 
                    Veiculo.Price
                        +(TemFreioABS ? FREIO_ABS : 0)
                        +(TemArCondicionado ? AR_CONDICIONADO : 0)
                        +(TemMP3Player ? MP3_PLAYER : 0));
            }
        }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            // this.Title = $"{this.Title}: {this.Veiculo.Name}";
            this.BindingContext = this;
        }

        private void ButtonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}