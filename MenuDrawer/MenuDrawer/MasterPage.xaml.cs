using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MenuDrawer
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPageViewModel mpVM = new MasterPageViewModel();
        public MasterPage()
        {
            InitializeComponent();
            this.BindingContext = mpVM;
        }
    }
}
