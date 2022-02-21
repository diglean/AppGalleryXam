using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Layouts.BarraDeRolagemLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        private void RolarParaSegundaLabel(object sender, EventArgs e)
        {
            BarraDeRolage.ScrollToAsync(SegundaLabel, ScrollToPosition.Start, true);
        }
    }
}