namespace Application.Response.Pcte;

public class Result<T>
{
    public string Message { get; set; }
    public T Data { get; set; }
}