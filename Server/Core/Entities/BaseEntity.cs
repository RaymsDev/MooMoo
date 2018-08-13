using MongoDB.Bson;

namespace MooMoo.ApplicationCore.Entities
{
  public class BaseEntity{
    public ObjectId Id { get; set; }
  }
}