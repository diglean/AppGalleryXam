using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #region NavigationPage
            //var pagina = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            //MainPage = pagina;
            #endregion
            #region Modal
            //MainPage = new XamarinForms.Paginas.Modal.Conteudo01(); MODAL
            #endregion
            #region Carrossel C#
            //var pagina = new CarouselPage(); !-!-!CARROSSEL EM C#!-!-!
            //pagina.Children.Add(new XamarinForms.PaginaDeCarrossel.Conteudo01());
            //pagina.Children.Add(new XamarinForms.PaginaDeCarrossel.Conteudo02());
            //pagina.Children.Add(new XamarinForms.PaginaDeCarrossel.Conteudo03());
            //pagina.CurrentPage = pagina.Children[1];
            //MainPage = pagina;
            #endregion
            #region MasterDetailPage
            //var pagina = new MasterDetailPage();
            ////Menu
            //pagina.Master = ;
            ////Conteúdo
            //pagina.Detail = ;
            #endregion
            #region TabbedPages
            //MainPage = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            #endregion
            MainPage = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
