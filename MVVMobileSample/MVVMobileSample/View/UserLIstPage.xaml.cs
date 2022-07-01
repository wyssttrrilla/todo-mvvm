using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMobileSample.Model;
using MVVMobileSample.View;
using MVVMobileSample.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMobileSample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserLIstPage : ContentPage
    {
        public UserLIstPage()
        {
            InitializeComponent();
           
        }
    }
}