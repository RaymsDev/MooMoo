using System;

namespace MooMoo.ApplicationCore.Entities {
  public class ProductEntity : BaseEntity {
    public string Name {get;set;}
    public int Quantity {get;set;}
    public DateTime DeliverDate {get;set;}
    public DateTime RegisterDate {get;set;}
    public StateEntity State {get;set;}
  }
}