namespace Application.Response.Psi;

public class Result<T>
{
    public string Message { get; set; }
    public T Data { get; set; }
}