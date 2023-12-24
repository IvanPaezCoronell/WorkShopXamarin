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
    public partial class UsersPage : ContentPage
    {

        private string apiURL = "https://jsonplaceholder.typicode.com/users";
        HttpClient client = new HttpClient();
        public UsersPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(apiURL);
            IEnumerable<UserModel> listUsers = JsonConvert.DeserializeObject<IEnumerable<UserModel>>(content);
            listaUsuarios.ItemsSource = new ObservableCollection<UserModel>(listUsers);
            base.OnAppearing();
        }
    }
}