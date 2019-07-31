namespace SaludoEquipo {
    public class SoccerPlayer : Player {
        private string _PiernaHabil;
        private string _Posicion;
        public string  PiernaHabil
        {
            get { return _PiernaHabil; }
        }

        public string Posicion {
            get { return _Posicion; }
        }
        
        public SoccerPlayer(string nombre, string apellido, Saludo saludo, string piernaHabil, string posicion)
        : base(nombre, apellido, saludo)
        {
            this._PiernaHabil = piernaHabil;
            this._Posicion = posicion;
        }
    }
}