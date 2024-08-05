using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui
{
    public partial class View2ViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        

        public View2ViewModel(INavigation navigation)
        {
            _navigation = navigation;
            GoToView1Command = new RelayCommand(async () => await NavigateToView1Async());
        }

        public IRelayCommand GoToView1Command { get; }

        private async Task NavigateToView1Async()
        {
            await _navigation.PushAsync(new View1());
        }
    }
}
