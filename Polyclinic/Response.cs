namespace Polyclinic
{
    public class Response<T>
    {
        public T Obj { get; set; }

        public string errorMessage { get; set; }
    }
}
