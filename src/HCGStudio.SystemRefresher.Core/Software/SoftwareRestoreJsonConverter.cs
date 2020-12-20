using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HCGStudio.SystemRefresher.Core.Software
{
    public class SoftwareRestoreJsonConverter : JsonConverter<SoftwareRestore>
    {
        public override SoftwareRestore? Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, SoftwareRestore value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}