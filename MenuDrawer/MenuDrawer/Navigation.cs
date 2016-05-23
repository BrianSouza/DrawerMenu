using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuDrawer
{
    public class Navigation : INavigationService
    {
        public async Task NavegarMenu(MasterPageItem menu)
        {
            await App.Current.MainPage.Navigation.PushAsync(new ContactsPage());
        }
    }
}
