using AttendanceSupport.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AttendanceSupport.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}