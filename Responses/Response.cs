using System.Runtime.Serialization;

namespace Responses
{
    [DataContract]
    public class Response : IResponse
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
