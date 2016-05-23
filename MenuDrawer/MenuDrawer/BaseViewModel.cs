using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MenuDrawer
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected INavigationService _Navigation;
       
        public BaseViewModel()
        {
            _Navigation = DependencyService.Get<INavigationService>();
        }
        protected void Notify(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this,new PropertyChangedEventArgs (propertyName));
        }
    }
}
