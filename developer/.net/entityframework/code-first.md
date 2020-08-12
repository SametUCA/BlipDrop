# Code First

Entity paketleri nuget package üzerinden yüklendikten sonra komut penceresine şu kodlar yazılı

Eğer belli tabloları entegre edeceksen

```text
Scaffold-DbContext "Server=.;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -table Personeller, Satislar, Musteriler
```

Direkt veritabanı ve içinde ki tüm tabloları çekmek istersek

```text
Scaffold-DbContext "Server=.;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Veritabanı güncellenirse -force parametresi eklenir
```

```text
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<NorthwindContext>(_ => _.UseSqlServer("Server=.;Database=Northwind;Trusted_Connection=True;"));
        services.AddMvc();
    }
 
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();
 
        app.UseMvc(_ => _.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"));
    
```

