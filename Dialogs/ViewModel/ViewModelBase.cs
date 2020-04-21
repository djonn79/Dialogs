using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dialogs.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public DialogResult DialogResult { get; set; }
        public WindowType WindowType { get; set; }
    }
}
