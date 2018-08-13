using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MooMoo.ApplicationCore.Interfaces {
  public interface ISpecification<T> {
    Expression<Func<T, bool>> Critera { get; set; }
  }
}