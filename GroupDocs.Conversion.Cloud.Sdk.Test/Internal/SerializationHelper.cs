using System;
using System.IO;
using System.Text;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Internal
{
    internal class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                           ? JsonConvert.SerializeObject(
                               obj,
                               new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
                           : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (type == typeof(Stream))
                {
                    return new MemoryStream(Encoding.UTF8.GetBytes(json));
                }

                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    return JsonConvert.DeserializeObject(json, type);
                }

                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(json);
                return JsonConvert.SerializeXmlNode(xmlDoc);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jse)
            {
                throw new ApiException(500, jse.Message);
            }
            catch (System.Xml.XmlException xmle)
            {
                throw new ApiException(500, xmle.Message);
            }
        }

        internal abstract class JsonCreationConverter<T> : JsonConverter
        {            
            public override bool CanConvert(Type objectType)
            {
                return typeof(T).IsAssignableFrom(objectType);
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                var jsonObject = JObject.Load(reader);
                T target = this.Create(objectType, jsonObject);
                serializer.Populate(jsonObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            /// <summary>
            /// Create an instance of objectType, based properties in the JSON object.
            /// </summary>
            /// <param name="objectType">type of object expected.</param>
            /// <param name="jsonObject">
            /// Contents of JSON object that will be deserialized.
            /// </param>
            /// <returns>An instance of objectType.</returns>
            protected abstract T Create(Type objectType, JObject jsonObject);
        }       
    }
}