using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WorkShopXamarin.Models
{
    internal class UserModel : INotifyPropertyChanged
    {
        private string name;
        private string email;

        public string Name
        {
            get; set;

        }

        public string Email
        {
            get; set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
