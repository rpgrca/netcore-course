using System;

namespace SaludoEquipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Team<BasketballPlayer> teamBasket = new Team<BasketballPlayer>();
            teamBasket.Add(new BasketballPlayer("Juan", "Perez", new Saludo("levanta mano derecha"), 1.95));
            teamBasket.Add(new BasketballPlayer("Martin", "Perez", new Saludo("levanta mano izquierda"), 1.94));
            teamBasket.Add(new BasketballPlayer("Miguel", "Perez", new Saludo("levanta pulgar"), 1.93));
            teamBasket.Add(new BasketballPlayer("Emilio", "Perez", new Saludo("señala al cielo"), 1.92));
            teamBasket.Add(new BasketballPlayer("Emiliano", "Perez", new Saludo("salta"), 1.91));
            teamBasket.Saludar();
        }
    }
}
