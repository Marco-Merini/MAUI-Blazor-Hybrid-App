using LanchesLibrary.Data;

namespace LanchesMaui.Data;

public class LancheService : ILancheService
{
    public async Task<List<Lanche>> LoadLanchesAsync()
    {
        await Task.Delay(1000);
        var lanches = new[]
        {
        new Lanche() {Name= "Cheese Burger", Description= "Pão e Hamburger tradicional com queijo" },
        new Lanche() {Name= "Cheese Salada", Description= "Pão e Hamburger tradicional com queijo e alface" },
        new Lanche() { Name = "Cheese Salada Egg", Description = "Pão e Hamburger tradicional com queijo e alface e ovo" },
        new Lanche() { Name = "Misto Quente", Description = "Pão de forma, presunto e queijo" },
        new Lanche() { Name = "Bauru", Description = "Pão de forma, presunto, queijo, tomate e queijo" },
        };
        return lanches.ToList();
    }
}

