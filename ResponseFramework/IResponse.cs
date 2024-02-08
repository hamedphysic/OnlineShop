
using System.Net;

namespace ResponseFramework
{
    internal interface IResponse<TResult>
    {
        bool IsSuccess { get; set; }
        string? Message { get; set; }
        string? ErrorMessage { get; set; }
        TResult? Result { get; set; }
        HttpStatusCode HttpStatusCode { get; set; }
    }
}
