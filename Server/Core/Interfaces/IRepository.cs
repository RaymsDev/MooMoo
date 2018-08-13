using System.Collections.Generic;
using MooMoo.ApplicationCore.Entities;

namespace MooMoo.ApplicationCore.Interfaces {
  public interface IRepository<T> where T : BaseEntity {
    T Add (T entity);
    T Delete (T entity);
    T Get (int id);
    T Get (ISpecification<T> specification);
    IEnumerable<T> List ();
    IEnumerable<T> List (ISpecification<T> specification);

    T Update (T entity);

  }
}