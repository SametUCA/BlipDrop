# Bağlantı Ayarları - Migrations

[https://www.youtube.com/watch?v=AHqIrJ\_PlPY](https://www.youtube.com/watch?v=AHqIrJ_PlPY)

Context içerisinde ctor üretilir.

```text
public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
            
        }
```

App.json içerisine

\(Virgül\)

```text
"ConnectionStrings": {
    "DevConnection": "Server=(localdb)\\MSSQLLocalDB;Database=School;Trusted_Connection=True;MultipleActiveResultSets=True"
```

Startup içerisindeki configureservice metodu içerisine,

```text
services.AddDbContext<SchoolContext>(options=>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
```



