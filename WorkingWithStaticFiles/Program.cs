using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// #1
//app.UseDefaultFiles();
//app.UseStaticFiles();

// #2
//app.UseDirectoryBrowser();
//app.UseStaticFiles();

// #3
//app.UseStaticFiles(new StaticFileOptions()
//{
//    FileProvider = new PhysicalFileProvider(Path.Combine(Environment.CurrentDirectory, @"wwwroot\html")),
//    RequestPath = new PathString("/pages")
//}); ;
//app.UseStaticFiles();

//#4
//app.UseFileServer(new FileServerOptions
//{
//    EnableDefaultFiles = false,
//    EnableDirectoryBrowsing = true,
//});

//#5
app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\html")),
    RequestPath = new PathString("/pages")
}); ;

app.Run(async context => await context.Response.WriteAsync("Hello User"));
app.Run();
