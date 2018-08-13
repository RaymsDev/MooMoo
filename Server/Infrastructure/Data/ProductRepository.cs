using System.Collections.Generic;
using MongoDB.Driver;
using MooMoo.ApplicationCore.Entities;
using MooMoo.ApplicationCore.Interfaces;

namespace MooMoo.Infrastructure.Data {
  public class ProductRepository : IRepository<ProductEntity> {
    private IMongoDatabase db;
    private const string COLLECTION = "Product";
    public ProductRepository () {
      // TODO : add env file
      var connectionString = "mongodb://localhost:27017";
      var client = new MongoClient(connectionString);
      this.db = client.GetDatabase("MooMoo");
    }
    public ProductEntity Add (ProductEntity entity) {
      var collection = this.db.GetCollection<ProductEntity>(COLLECTION);
      collection.InsertOne(entity);
      return entity;
    }

    public ProductEntity Delete (ProductEntity entity) {
      throw new System.NotImplementedException ();
    }

    public ProductEntity Get (int id) {
      return new ProductEntity ();
    }

    public ProductEntity Get (ISpecification<ProductEntity> specification) {
      throw new System.NotImplementedException ();
    }

    public IEnumerable<ProductEntity> List () {
      throw new System.NotImplementedException ();
    }

    public IEnumerable<ProductEntity> List (ISpecification<ProductEntity> specification) {
      throw new System.NotImplementedException ();
    }

    public ProductEntity Update (ProductEntity entity) {
      throw new System.NotImplementedException ();
    }
  }
}