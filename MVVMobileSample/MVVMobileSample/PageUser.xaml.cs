using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMobileSample.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMobileSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageUser : ContentPage
    {
        public UserViewModel ViewModel { get; private set; }
        public PageUser(UserViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}