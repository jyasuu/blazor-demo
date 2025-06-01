# blazor-demo


```sh
dotnet new sln
dotnet sln add blazor-demo
dotnet sln add blazor-wasm-demo

dotnet run -p blazor-demo
dotnet watch -p blazor-demo

dotnet new razorcomponent -n Todo -o blazor-demo/Components/Pages
dotnet new razorcomponent -n Index -o blazor-demo/Components/Pages/Pizza
dotnet new razorcomponent -n Pizzas -o blazor-demo/Components/Pages/Pizza
dotnet new razorcomponent -n Pizza -o blazor-demo/Components/Pages/Pizza
dotnet new razorcomponent -n PizzaTopping  -o blazor-demo/Components/Pages/Pizza
dotnet new razorcomponent -n PizzaToppings  -o blazor-demo/Components/Pages/Pizza



dotnet add blazor-demo package Microsoft.EntityFrameworkCore --version 6.0.8
dotnet add blazor-demo package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.8
dotnet add blazor-demo package System.Net.Http.Json --version 6.0.0

```