var builder = WebApplication.CreateBuilder(new WebApplicationOptions { WebRootPath = "Static" });
var app = builder.Build();
app.UseStaticFiles();


app.Run(async context => await context.Response.WriteAsync("Hello User"));
app.Run();
