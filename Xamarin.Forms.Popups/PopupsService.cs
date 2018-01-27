/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System.Threading.Tasks;

namespace Xamarin.Forms.Popups
{
    public class PopupsService : IPopupsService
    {
        public async Task<string> DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons)
        {
            var MainPage = Application.Current.MainPage;           
            return await MainPage.DisplayActionSheet(title, cancel, destruction, buttons);
        }

        public async Task DisplayAlert(string title, string message, string cancel)
        {
            var MainPage = Application.Current.MainPage;
            await MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            var MainPage = Application.Current.MainPage;
            return await MainPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}
