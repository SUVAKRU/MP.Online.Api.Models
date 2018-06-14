using ServiceStack;

namespace Map.Online.Api.Models.Common
{
   public  class BaseResponse : IHasResponseStatus
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
