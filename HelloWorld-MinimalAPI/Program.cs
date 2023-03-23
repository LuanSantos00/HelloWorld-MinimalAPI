var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
@"Para visualizar a mensagem em português, coloque no fim da url br!


To view the message in Portuguese, put en at the end of the url!");

app.MapGet("/en", () => "Hello World! This is my first minimal api with c#");

app.MapGet("/br", () => "Olá Mundo! Esta é minha primeira minimal api com c#");

app.Run();
