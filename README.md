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

```