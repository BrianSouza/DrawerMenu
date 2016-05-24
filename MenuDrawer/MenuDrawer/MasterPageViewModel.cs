using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuDrawer
{
    public class MasterPageViewModel : BaseViewModel
    {
        private ObservableCollection<MasterPageItem> listMPI;
        public MasterPageViewModel()
        {
            FillList();
        }

        public ObservableCollection<MasterPageItem> ListMPI
        {
            get
            {
                return listMPI;
            }

            set
            {
                listMPI = value;
                this.Notify("ListMPI");
            }
        }

       

        private void FillList()
        {
            ListMPI = new ObservableCollection<MasterPageItem>
            {
                new MasterPageItem {Title = "Contacts",
                IconSource = "icon.png",
                TargetType = typeof(ContactsPage) },

                new MasterPageItem {Title = "TodoList",
                IconSource = "icon.png",
                TargetType = typeof(TodoListPage) },

                new MasterPageItem { Title = "Reminders",
                IconSource = "icon.png",
                TargetType = typeof(ReminderPage)}
            };
        }
    }
}
