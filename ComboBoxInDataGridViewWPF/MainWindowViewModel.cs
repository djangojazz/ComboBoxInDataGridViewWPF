using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxInDataGridViewWPF
{
  public sealed class MainWindowViewModel : BaseViewModel
  {
    private ObservableCollection<TransactionSimple> _simples;
    private ObservableCollection<TransactionComplex> _complexes;
    
    
    public MainWindowViewModel()
    {
      FakeRepo();
    }
    
    ReadOnlyCollection<Type> Types { get; } = new ReadOnlyCollection<Type>(new List<Type> { new Type(1, "Credit"), new Type(2, "Debit") });


    public ObservableCollection<TransactionSimple> Simples
    {
      get { return _simples; }
      set
      {
        _simples = value;
        OnPropertyChanged(nameof(Simples));
      }
    }
    public ObservableCollection<TransactionComplex> Complexes
    {
      get { return _complexes; }
      set
      {
        _complexes = value;
        OnPropertyChanged(nameof(Complexes));
      }
    }

    private void FakeRepo()
    {
      var data = new List<TransactionComplex>
      {
        new TransactionComplex(1, "Got some money", Types[0], 1000m),
        new TransactionComplex(2, "spent some money", Types[1], 100m),
        new TransactionComplex(3, "spent some more money", Types[1], 300m)
      };

      Complexes = new ObservableCollection<TransactionComplex>(data);
      Simples = new ObservableCollection<TransactionSimple>(data.Select(x => new TransactionSimple(x.TransactionId, x.Description, x.Type.TypeId, x.Amount)));
    }
    
    
  }
}
