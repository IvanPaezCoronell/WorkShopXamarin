using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using WorkShopXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkShopXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumsPage : ContentPage
    {

        private string apiURL = "https://jsonplaceholder.typicode.com/photos";
        HttpClient client = new HttpClient();
        public AlbumsPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(apiURL);
            IEnumerable<AlbumModel> listAlbum = JsonConvert.DeserializeObject<IEnumerable<AlbumModel>>(content);
            listaAlbunes.ItemsSource = new ObservableCollection<AlbumModel>(listAlbum);
            base.OnAppearing();
        }
    }
}