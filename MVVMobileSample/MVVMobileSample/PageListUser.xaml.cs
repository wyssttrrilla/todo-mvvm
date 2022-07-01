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
    public partial class PageListUser : ContentPage
    {
       
        public PageListUser()
        {
            InitializeComponent();
            BindingContext = new UserListViewModel() { Navigation = this.Navigation};
        }
    }
}