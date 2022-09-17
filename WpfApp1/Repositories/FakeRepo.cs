using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repositories
{
    public class FakeRepo
    {

        public List<Beer> GetAll()
        {
            return new List<Beer>
            {
                new Beer{Name="Xirdalan",Price=10.5,Volume=0.5,ImagePath="Images\\xirdalan.jpg"},
                new Beer{Name="Cooler",Price=6.5,Volume=0.3,ImagePath="Images\\kuler.jpg"},
                new Beer{Name="Baltika Butulka",Price=8.5,Volume=1,ImagePath="Images\\baltika_butulka.png"},
                new Beer{Name="Baltika Demir",Price=20.5,Volume=1,ImagePath="baltika.jpg"},
            };
        }

    }
}
