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
        private MasterPageItem mpiSelecionado;
        private int indexMPI;
        private NavigationPage NP;

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

        public MasterPageItem MpiSelecionado
        {
            get
            {
                return mpiSelecionado;
            }

            set
            {
                mpiSelecionado = value;
                this.Notify("MpiSelecionado");
            }
        }

        private NavigationPage Navegar()
        {
            if (mpiSelecionado != null)
                return new NavigationPage((Page)Activator.CreateInstance(mpiSelecionado.TargetType));
            else
                return null;

        }

        public int IndexMPI
        {
            get
            {
                return indexMPI;
            }

            set
            {
                indexMPI = value;
                MpiSelecionado = ListMPI[IndexMPI];
                this.Notify("IndexMPI");

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
