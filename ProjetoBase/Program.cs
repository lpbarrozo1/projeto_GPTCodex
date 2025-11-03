var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
using System;

namespace ProjetoBase;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao projeto base em .NET!");

        if (args.Length > 0)
        {
            Console.WriteLine("Argumentos fornecidos:");
            foreach (var argument in args)
            {
                Console.WriteLine($" - {argument}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum argumento foi passado para a aplicação.");
        }
    }
}
