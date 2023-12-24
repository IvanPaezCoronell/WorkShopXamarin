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
    public partial class PostsPage : ContentPage
    {
        private string apiURL = "https://jsonplaceholder.typicode.com/posts";
        HttpClient client = new HttpClient();
        public PostsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(apiURL);
            IEnumerable<PostModel> listPosts = JsonConvert.DeserializeObject<IEnumerable<PostModel>>(content);
            listaPosts.ItemsSource = new ObservableCollection<PostModel>(listPosts);
            base.OnAppearing();
        }
    }
}