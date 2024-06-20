var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


//app.Use are use for the next middleware and  next.Invoke are use for the execute the next middleware 
//If we use the app.Run() its use execute tehe last middleware.
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Mayur \n");
    await next();
});

//await.next() are useful for the next middleware execute 
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Abhishek \n");
    await next();
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Chetan \n");
    await next();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Welcome to ASP.Net Core 6");
});
//app.Run() are use for the last execute the Last Middleware.after the app.run() we can not execute the next middleware
app.Run();

//app.Map() Method are use for the out own URL we can use hear.

