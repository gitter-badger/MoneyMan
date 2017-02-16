namespace MoneyMan.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainPageViewModel : BindableBase
    {
        public AccountsPanelViewModel AccountsPanel { get; set; }
    }
}
