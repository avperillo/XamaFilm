using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamaFilm.Views
{

    public class MainViewMenuItem
    {
        public MainViewMenuItem()
        {
            TargetType = typeof(HomeView);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}