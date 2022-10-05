using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoneGrouping : ContentPage
    {
        public ObservableCollection<PhoneGroup> phoneList { get; set; } = new ObservableCollection<PhoneGroup>();
        public PhoneGrouping()
        {
            InitializeComponent();

            phoneList.Add(new PhoneGroup("Xiaomi", new[]
          {
                new Phone
                {
                    Company = "Xiaomi Company",
                    Title = "Xiaomi M2",
                    Price = 3000
                },

                new Phone
                {
                    Company = "Xiaomi Company2",
                    Title = "Xiaomi M3",
                    Price = 8000
                },



            }));

            phoneList.Add(new PhoneGroup("Samsung", new[]
            {
                new Phone
                {
                    Company = "Samsung Company",
                    Title = "Samsumg Galaxy",
                    Price = 600
                },

                new Phone
                {
                    Company = "Samsung Company",
                    Title = "Samsumg A7",
                    Price = 700
                },

            }));

            algo.ItemsSource = phoneList;
        }
    }
}