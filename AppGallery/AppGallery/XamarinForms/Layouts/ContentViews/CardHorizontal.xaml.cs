using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Layouts.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardHorizontal : ContentView
    {
        private string _titulo { get; set; }
        private string _texto{ get; set; }
        private Color _cor{ get; set; }

        public string Titulo { 
            get { return _titulo; }
            set { _titulo = value; CardTitulo.Text = _titulo; }
        }


        public string Texto {
            get { return _texto; }
            set { _texto = value; CardTexto.Text = _texto; }
        }
        public Color Cor { 
            get { return _cor; }
            set { _cor = value; Card.BackgroundColor = _cor; }
        }

        public CardHorizontal()
        {
            InitializeComponent();
            Card.BackgroundColor = Cor;
            CardTitulo.Text = Titulo;
            CardTexto.Text = Texto;
        }
    }
}