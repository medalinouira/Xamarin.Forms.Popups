/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System.Threading.Tasks;

namespace Xamarin.Forms.Popups
{
    public interface IPopupsService
    {
        Task DisplayAlert(string title, string message, string cancel);
        Task<bool> DisplayAlert(string title, string message, string accept, string cancel);
        Task<string> DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons);
    }
}
