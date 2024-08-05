using Microsoft.Maui.Controls;
namespace maui
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
        }

       
    }

}

