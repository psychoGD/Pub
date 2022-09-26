using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Commands.RelayCommandProject.Commands;
using WpfApp1.Models;
using WpfApp1.Repositories;

namespace WpfApp1.ViewModel
{
    public class AppViewModel:BaseViewModel
    {

        public ObservableCollection<Beer> Beers { get; set; }

        private Beer beer;
        //private BitmapImage image;

        //public BitmapImage ImagePath
        //{
        //    get { return image; }
        //    set { image = value; OnPropertyChanged(); }
        //}
        //private string image;

        //public string ImgPath
        //{
        //    get { return image; }
        //    set { image = value;OnPropertyChanged(); }
        //}
        private Image image;

        public Image ImagePath
        {
            get { return image; }
            set { image = value; OnPropertyChanged(); }
        }





        public Beer Beer
        {
            get { return beer; }
            set { beer = value;OnPropertyChanged(); }
        }
        //Commands
        public RelayCommand SelectCommand { get; set; }

        public RelayCommand IncreaseCountCommand { get; set; }

        public RelayCommand DecreaseCountCommand { get; set; }

        public int Count { get; set; }


        private string countstr;

        public string CountStr
        {
            get { return countstr; }
            set { countstr = value;OnPropertyChanged(); }
        }


        public AppViewModel()
        {
            FakeRepo fakeRepo = new FakeRepo();
            Beers = new ObservableCollection<Beer>(fakeRepo.GetAll());

            SelectCommand = new RelayCommand(o =>
            {
                var beer = o as Beer;
                Beer = beer;
                FileInfo fileInfo = new FileInfo(beer.ImagePath);
                Uri fileUri = new Uri(fileInfo.FullName);

                ImagePath = new Image();

                var uriSource = new Uri($@"{beer.ImagePath}", UriKind.Relative);
                ImagePath.Source = new BitmapImage(uriSource);
            });

            IncreaseCountCommand = new RelayCommand(o =>
            {
                Count++;
                CountStr = Count.ToString();
            });
            DecreaseCountCommand = new RelayCommand(o =>
            {
                if(Count > 0)
                Count--;
                CountStr = Count.ToString();

            });
        }

    }
}
