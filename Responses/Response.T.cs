using System.Runtime.Serialization;

namespace Responses
{
    [DataContract]   
    public sealed class Response<T> : IResponse<T>
    {
       [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public T Item { get; set; }
    }
}
