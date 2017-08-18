using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxInDataGridViewWPF
{
  public abstract class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler handler = this.PropertyChanged;
      if (handler != null)
      {
        var e = new PropertyChangedEventArgs(propertyName);
        handler(this, e);
      }
    }
  }
}
