using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBikeShop
{
    /// <summary>
    /// Bindings.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Bindings : Page
    {
        public Bindings()
        {
            InitializeComponent();

            Car c = new Car {
                //Speed = 100,
                Color = Colors.Crimson,
                Driver = new Human
                { FirstName = "Nick",
                    HasDrivingLicense = true
                }
            };

            //txtSpeed.DataContext = c; //필수!!! 이 데이터를 xaml로 보내야 함요.
            //txtColor.DataContext = c;
            //txtFirstName.DataContext = c;
            this.DataContext = c; //this를 사용하여 인스턴스들 다 사용하게끔 만듬. 와우 시발 존나 멋지네
            //txtSpeed.Text = c.Color.ToString(); //고전적인 윈폼방식

            var carlist = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                carlist.Add(new Car { 
                    //Speed = i * 10,
                    Color = Colors.Aquamarine
                });
            }

            lbxCars.DataContext = carlist;
        }
    }
}
