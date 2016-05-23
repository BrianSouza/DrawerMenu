using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDrawer
{
    public interface INavigationService
    {
        Task NavegarMenu(MasterPageItem menu);
    }
}
