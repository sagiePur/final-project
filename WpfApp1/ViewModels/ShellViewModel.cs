using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        public Dictionary<string, Screen> ViewsDict { get; set; } = new Dictionary<string, Screen>
        {
        };

        public void ActivateView(string viewModelName)
        {
            DisplayName = $"Shop {viewModelName}";

            ActivateItem(ViewsDict[viewModelName]);
        }
    }
}
