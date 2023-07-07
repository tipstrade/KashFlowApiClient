using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipsTrade.KashFlow {
  /// <summary>
  /// Represents errors that occur during a KashFlowAPISoapClient method excecution.
  /// </summary>
  public class KashFlowException : Exception {
    /// <summary>
    /// Gets or sets the status returned by the KashFlowAPISoapClient.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the net.foramundi.KashFlowClient.KashFlowException class.
    /// </summary>
    public KashFlowException() : base() { }

    /// <summary>
    /// Initializes a new instance of the net.foramundi.KashFlowClient.KashFlowException class
    /// with a specified error message. 
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public KashFlowException(string message) : base(message) { }

    /// <summary>
    /// Initializes a new instance of the net.foramundi.KashFlowClient.KashFlowException class
    /// with a specified error message and a reference to the inner exception that is the cause of
    /// this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception, or a null reference
    /// (Nothing in Visual Basic) if no inner exception is specified.
    /// </param>
    public KashFlowException(string message, Exception innerException) : base(message, innerException) { }
  }
}
