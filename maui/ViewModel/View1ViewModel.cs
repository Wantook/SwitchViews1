using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui
{
    public partial class View1ViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        

        public View1ViewModel(INavigation navigation)
        {
            _navigation = navigation;
            GoToView2Command = new RelayCommand(async () => await NavigateToView2Async());
        }

        public IRelayCommand GoToView2Command { get; }

        private async Task NavigateToView2Async()
        {
            await _navigation.PushAsync(new View2());
        }
    }
}
