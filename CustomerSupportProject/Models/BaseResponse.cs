namespace CustomerSupportApi.Models
{
    public class BaseResponse<T> where T : new()
    {        
        public bool IsSucceed => string.IsNullOrEmpty(Error);
        public string Error { get; private set; }
        public T Result { get; set; }

        public BaseResponse()
        {
            Result = new T();
        }

        public void SetError(string message) => Error = message;
    }
}
