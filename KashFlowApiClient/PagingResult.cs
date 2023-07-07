using System;
using System.Collections.Generic;
using System.Text;

namespace TipsTrade.KashFlow {
  public class PagingResult<T> {
    public int TotalPages { get; set; }

    public int TotalRecords { get; set; }

    public T Result { get; set; }
  }
}
