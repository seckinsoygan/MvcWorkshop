using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Security.Authentication;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

string connectionString = configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // ...

    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler(errorApp =>
        {
            errorApp.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var ex = context.Features.Get<IExceptionHandlerFeature>()?.Error;

                // Hata durum koduna g�re y�nlendirme yapabilirsiniz
                if (ex is AuthenticationException)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    // �zel bir hata sayfas�na y�nlendirme yapabilirsiniz
                    context.Response.Redirect("/ErrorPage/Page404/");
                }
                else if (ex is AuthenticationException)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    // �zel bir hata sayfas�na y�nlendirme yapabilirsiniz
                    context.Response.Redirect("/ErrorPage/Page404/");
                }
                else
                {
                    // Varsay�lan hata durum kodu ve y�nlendirme
                    context.Response.Redirect("/ErrorPage/Page404/");
                }
            });
        });

        app.UseStatusCodePagesWithRedirects("/Error/{0}");
        app.UseHsts();
    }

    // ...
}

app.UseStatusCodePagesWithRedirects("/error/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
