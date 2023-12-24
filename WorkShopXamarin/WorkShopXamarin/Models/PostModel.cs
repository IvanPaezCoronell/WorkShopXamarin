using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WorkShopXamarin.Models
{
    internal class PostModel : INotifyPropertyChanged
    {
        private int userId;
        private int id;
        private string title;
        private string body;

        public int UserId
        {
            get; set;
        }
        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;

        }
        public string Body
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
