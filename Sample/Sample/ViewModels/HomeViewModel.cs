/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;
using Xamarin.Forms;
using Sample.IViewModels;
using System.Windows.Input;
using Xamarin.Forms.Popups;
using Xamarin.Forms.Internals;

namespace Sample.ViewModels
{
    public class HomeViewModel : IHomeViewModel
    {
        private IPopupsService _iPopupsService;

        public ICommand BtnTappedCommand { get; set; }

        [Preserve]
        public HomeViewModel()
        {
            this._iPopupsService = DependencyService.Get<IPopupsService>(DependencyFetchTarget.GlobalInstance);
            BtnTappedCommand = new Command<String>(BtnTapped);
        }

        private async void BtnTapped(string param)
        {
            switch (param)
            {
                case "DisplayAlert":
                    await this._iPopupsService.DisplayAlert("DisplayAlert", "This a DisplayAlert", "Cancel");
                    break;
                case "DisplayActionSheet":
                    await this._iPopupsService.DisplayActionSheet("DisplayActionSheet", "Cancel", "Destruction", "Button1", "Button2", "Button3");
                    break;
                default:
                    break;
            }
        }
    }
}
