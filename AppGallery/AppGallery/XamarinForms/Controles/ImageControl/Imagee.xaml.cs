using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ImageControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imagee : ContentPage
    {
        public Imagee()
        {
            InitializeComponent();

            //Imagem01.Source = ImageSource.FromResource("AppGallery.XamarinForms.Controles.ImageControl.background.jpg");
        }
    }
}