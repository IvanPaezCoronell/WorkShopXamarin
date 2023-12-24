using System.ComponentModel;

namespace WorkShopXamarin.Models
{
    internal class AlbumModel : INotifyPropertyChanged
    {
        private int id;
        private string title;
        private string url;


        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public string Url
        {
            get; set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
