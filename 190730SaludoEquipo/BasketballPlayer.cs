namespace SaludoEquipo {
    public class BasketballPlayer : Player {
        private double _Altura;
        public double Altura
        {
            get { return _Altura; }
            set { _Altura = value; }
        }

        public BasketballPlayer(string nombre, string apellido, Saludo saludo, double altura) 
        : base(nombre, apellido, saludo) {
            this.Altura = altura;
        }
    }
}