// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Property.Optional
{
    public partial class PlainTimeProperty : IJsonModel<PlainTimeProperty>
    {
        void IJsonModel<PlainTimeProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        PlainTimeProperty IJsonModel<PlainTimeProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual PlainTimeProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<PlainTimeProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        PlainTimeProperty IPersistableModel<PlainTimeProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual PlainTimeProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<PlainTimeProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(PlainTimeProperty plainTimeProperty) => throw null;

        public static explicit operator PlainTimeProperty(ClientResult result) => throw null;
    }
}
