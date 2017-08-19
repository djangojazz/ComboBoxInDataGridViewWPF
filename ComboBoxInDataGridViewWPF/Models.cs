using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComboBoxInDataGridViewWPF
{
  public class Type
  {
    public Type(int typeId, string typeName)
    {
      TypeId = typeId;
      TypeName = typeName;
    }

    public int TypeId { get; set; }
    public string TypeName { get; set; }
  }


  public class TransactionSimple : BaseViewModel
  {
    public TransactionSimple(int transactionId, string description, int typeId, decimal amount)
    {
      TransactionId = transactionId;
      Description = description;
      TypeId = typeId;
      Amount = amount;
    }

    public int TransactionId { get; set; }
    public string Description { get; set; }
    private int _typeId;

    public int TypeId
    {
      get { return _typeId; }
      set
      {
        if (_typeId != 0) { MessageBox.Show($"Change to {value}"); }
        _typeId = value;
        OnPropertyChanged(nameof(TypeId));
      }
    }
    
    public decimal Amount { get; set; }
  }

  public class TransactionComplex : BaseViewModel
  {
    public TransactionComplex(int transactionId, string description, int typeId, string typeName, decimal amount)
    {
      TransactionId = transactionId;
      Description = description;
      Type = new Type(typeId, typeName);
      Amount = amount;
    }

    public TransactionComplex (int transactionId, string description, Type type, decimal amount)
	  {
      TransactionId = transactionId;
      Description = description;
      Type = type;
      Amount = amount;
	  }

    public int TransactionId { get; set; }
    public string Description { get; set; }
    private Type _type;

    public Type Type
    {
      get { return _type; }
      set
      {
        if(_type != null) { MessageBox.Show($"Change to {value.TypeName}"); }
        _type = value;
        OnPropertyChanged(nameof(Type));
      }
    }
    
    public decimal Amount { get; set; }
  }
}
