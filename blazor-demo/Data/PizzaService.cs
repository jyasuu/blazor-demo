namespace BlazingPizza.Data;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;



public class PizzaService
{
    private readonly PizzaStoreContext _db;
    

    public PizzaService(PizzaStoreContext db)
    {
        _db = db;
    }

    public List<Pizza> GetPizzas()
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
            return pizzas;
        }
        
    }

    public async Task<List<PizzaSpecial>> GetSpecials()
    {
        return _db.Specials.ToList();
    }

}