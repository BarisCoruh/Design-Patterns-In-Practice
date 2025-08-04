// See https://aka.ms/new-console-template for more information

var request = new HttpRequestBuilder()
    .SetMethod("POST")
    .SetUrl("https://api.example.com/user")
    .AddHeader("Authorization", "Bearer token")
    .AddHeader("Content-Type", "application/json")
    .SetBody("{ \"name\": \"Barış\", \"email\": \"baris@example.com\" }")
    .Build();

request.Send();