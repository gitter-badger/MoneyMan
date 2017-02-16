namespace MoneyMan.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Nerdbank.MoneyManagement.ViewModels;

    public class AccountsPanelViewModel : BindableBase
    {
        public ObservableCollection<AccountViewModel> Accounts { get; set; }
    }
}
