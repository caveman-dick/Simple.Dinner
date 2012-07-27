namespace Simple.Dinner
{
    using Simple.Web;

    [UriTemplate("/hello")]
    public class Hello : IGet
    {
        public Status Get()
        {
            return 200;
        }
    }
}
