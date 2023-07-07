using System;
using System.Threading.Tasks;

namespace TipsTrade.KashFlow.Test {
  class Program {
    static void Main(string[] args) {
      var code = KashFlowClient.GenerateMethodCode();

      Console.Write("Kashflow UserName: ");
      string username = Console.ReadLine();
      Console.Write("Kashflow Password: ");
      string password = Console.ReadLine();

      var client = new KashFlowClient(username, password);
      var accounts = Task.Run(async () => await client.GetBankAccountsAsync(new KashFlowAPI.GetBankAccountsRequest() {
      })).Result;
    }
  }
}
