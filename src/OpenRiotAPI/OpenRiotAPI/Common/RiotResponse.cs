namespace OpenRiotAPI.Common
{
    public class RiotResponse<T>
    {
        public string ErrorMessage { get; set; }

        public bool IsSucessful => string.IsNullOrEmpty(ErrorMessage);

        public T Result { get; set; }
    }
}
