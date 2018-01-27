/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Xamarin.Forms;
using Sample.IViewModels;
using Xamarin.Forms.Popups;

namespace Sample.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IHomeViewModel, HomeViewModel>();
            DependencyService.Register<IPopupsService, PopupsService>();
        }

        public IHomeViewModel Home
        {
            get
            {
                return DependencyService.Get<IHomeViewModel>();
            }
        }        
    }
}
