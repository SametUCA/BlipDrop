# Cors Politikası \[Kors\]

Gelen bilinmeyen istekleri güvenlik sebebi ile engeller.

Cors politikaları startup.cs içerisinde belirlenir.

```text

            services.AddCors(options => options.AddDefaultPolicy(policty =>
             policty.AllowAnyMethod().
             AllowAnyHeader().
             AllowCredentials().
             SetIsOriginAllowed(origin => true)
```

