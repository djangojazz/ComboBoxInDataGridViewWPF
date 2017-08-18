using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


  public class TransactionSimple
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
    public int TypeId { get; set; }
    public decimal Amount { get; set; }
  }

  public class TransactionComplex
  {
    public TransactionComplex(int transactionId, string description, int typeId, string typeName, decimal amount)
    {
      TransactionId = transactionId;
      Description = description;
      Type = new Type(typeId, typeName);
      Amount = amount;
    }

    public int TransactionId { get; set; }
    public string Description { get; set; }
    public Type Type { get; set; }
    public decimal Amount { get; set; }
  }
}
