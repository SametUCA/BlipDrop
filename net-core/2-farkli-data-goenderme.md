# 2 Farklı Data Gönderme



```text
List<Employee> employees = new List<Employee>()
            {
                new Employee{FirstName="Samet",LastName="Uca",ID=1},
                new Employee{FirstName="Samets",LastName="Ucas",ID=2}
            };
            List<string> cities = new List<string> { "İstanbul", "Ankara" };
            var model = new EmployeeListViewModel
            {
                Employee = employees,
                Cities = cities
            };
            
            return View(model);
```

