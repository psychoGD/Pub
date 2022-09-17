using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModel
{
    public class AppViewModel
    {
        public ObservableCollection<Beer> Beers { get; set; }

        public Beer Beer { get; set; }

    }
}
