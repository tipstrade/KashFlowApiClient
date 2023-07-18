#if NET6_0_OR_GREATER
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TipsTrade.KashFlow.v2.Model.Covnerters {
  internal class FlexibleDateTimeConverter : JsonConverter<DateTime> {
    public override bool HandleNull => false;

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
      var stringValue = reader.GetString();

      if (DateTime.TryParse(stringValue, out var dateValue)) {
        return dateValue;
      }

      throw new JsonException($"Cannot '{stringValue}' value to DateTime.");
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) {
      writer.WriteStringValue(value);
    }
  }
}
#endif