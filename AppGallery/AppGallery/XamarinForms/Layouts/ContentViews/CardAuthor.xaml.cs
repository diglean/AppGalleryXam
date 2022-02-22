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
    public partial class CardAuthor : ContentView
    {
        public static readonly BindableProperty NomeProperty = BindableProperty.Create("Nome", typeof(string), typeof(CardAuthor));
        public static readonly BindableProperty DescricaoProperty = BindableProperty.Create("Descricao", typeof(string), typeof(CardAuthor));
        public static readonly BindableProperty BoxViewColorProperty = BindableProperty.Create("BoxViewColor", typeof(Color), typeof(CardAuthor));


        public string Nome {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
                 
        }
        public string Descricao { 
            get { return (string)GetValue(DescricaoProperty); }
            set { SetValue(DescricaoProperty, value); }
        }
        public Color BoxViewColor { 
            get { return (Color)GetValue(BoxViewColorProperty); }
            set { SetValue(BoxViewColorProperty, value); }
        }
        public CardAuthor()
        {
            InitializeComponent();
        }
    }
}