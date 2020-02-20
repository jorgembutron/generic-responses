namespace Responses
{
    internal interface IResponse
    {
        bool Success { get; set; }

        string Message { get; set; }
    }
}
