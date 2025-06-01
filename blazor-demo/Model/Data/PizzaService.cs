namespace BlazingPizza.Data;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;



public class PizzaService
{
    
    private readonly ILocalStorageService _localStorage;
    private readonly ILogger<PizzaService> _logger;
    private const string PizzasKey = "Pizzas";

    public PizzaService(ILocalStorageService localStorage, ILogger<PizzaService> logger)
    {
        _localStorage = localStorage;
        _logger = logger;

    }

    public async Task<List<Pizza>> GetPizzasAsync()
    {
        {
            var pizzas = new List<Pizza>();
            var pizza = new Pizza();
            pizza.PizzaId = 1;
            pizza.Name = "test";
            pizza.Description = "test desc";
            pizza.Price = 1;
            pizza.Vegetarian = false;
            pizza.Vegan = false;
            pizzas.Add(pizza);

            _localStorage.SetItemAsync(PizzasKey, pizzas);
        }
        
        {
            
            var pizzas = await _localStorage.GetItemAsync<List<Pizza>>(PizzasKey) ?? new List<Pizza>();
            var pizza = new Pizza();
            pizza.PizzaId = 1;
            pizza.Name = "test";
            pizza.Description = "test desc";
            pizza.Price = 1;
            pizza.Vegetarian = false;
            pizza.Vegan = false;
            
            pizzas.Add(pizza);
            return pizzas;
        }
    }

}