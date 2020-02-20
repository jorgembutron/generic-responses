namespace Responses
{
    internal interface IResponse<T> : IResponse
    {
        T Item { get; set; }
    }
}
