#if NET6_0_OR_GREATER
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace TipsTrade.KashFlow.v2.Model {
  /// <summary>A collection of extension methods for the <see cref="Model"/> namespace.</summary>
  internal static class ModelExtensions {
    internal static IDictionary<string, object> AppendToDictionary(this IApiRequest request, IDictionary<string, object> dict) {
      foreach (var prop in request.GetType().GetProperties()) {
        var key = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name;

        if (key != null) {
          var value = prop.GetValue(request);

          if (value != null) {
            dict[key] = value;
          }
        }
      }

      return dict;
    }

    internal static IEnumerable<MemorableWordItem> FromWord(this IEnumerable<MemorableWordItem> items, string word) {
      return items.Select(x => {
        return new MemorableWordItem {
          Position = x.Position,
          Value = word.Substring(x.Position - 1, 1)
        };
      });
    }

    internal static IDictionary<string, object> ToDictionary(this IApiRequest request) {
      return request.AppendToDictionary(new Dictionary<string, object>());
    }
  }
}
#endif