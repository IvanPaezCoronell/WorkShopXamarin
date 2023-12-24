using System;
using Xamarin.Forms;

namespace WorkShopXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        //Metodo para navegar a la pagina de Usuarios
        private void Button_Clicked_Users(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsersPage());
        }


        //Metodo para navegar a la pagina de Posts
        private void Button_Clicked_Posts(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PostsPage());
        }


        //Metodo para navegar a la pagina de Albunes
        private void Button_Clicked_Albums(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlbumsPage());
        }



    }
}
