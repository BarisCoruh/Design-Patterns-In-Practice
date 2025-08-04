public class HttpRequestBuilder : IHttpRequestBuilder
{
    private readonly HttpRequest _request = new();

    public IHttpRequestBuilder SetMethod(string method)
    {
        _request.Method = method;
        return this;
    }

    public IHttpRequestBuilder SetUrl(string url)
    {
        _request.Url = url;
        return this;
    }

    public IHttpRequestBuilder AddHeader(string key, string value)
    {
        _request.Headers[key] = value;
        return this;
    }

    public IHttpRequestBuilder SetBody(string body)
    {
        _request.Body = body;
        return this;
    }

    public HttpRequest Build() => _request;
}