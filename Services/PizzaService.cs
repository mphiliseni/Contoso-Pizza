using Contoso_Pizza.Models;

namespace Contoso_Pizza.Services
{
    public static class PizzaServices
    {
        static List<Pizza> Pizzas {get;}
        static int nextId = 3;
        static PizzaServices()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Margherita", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Pepperoni", IsGlutenFree = false },
                new Pizza { Id = 3, Name = "Vegetarian", IsGlutenFree = true }
            };
        }
        public static List<Pizza> GetAll() => Pizzas; //Get all pizzas
        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id); //Get pizza by id

        //Update pizza
        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        //delete pizza
        public static void Delete(int id)
        {
            Pizza? pizza = Get(id);
            if (pizza is null) 
            return;
            Pizzas.Remove(pizza);
        }
        //update pizza
        public static void Update(Pizza pizza)
        {
            int index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1) return;
            Pizzas[index] = pizza;
        }
    }
}