using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialogs.ViewModel
{
    public class DialogVM : ViewModelBase
    {
        public DialogResult DialogResult { get; set; }
        public WindowType WindowType { get; set; }
    }
}
