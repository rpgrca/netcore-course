using System.Collections.Generic;

namespace SaludoEquipo {
    public class Team<T> where T : Player {
        private List<T> _Players;

        public List<T> Players {
            get { return _Players; }
        }

        public Team() {
            _Players = new List<T>();
        }

        public void Add(T player) {
            _Players.Add(player);
        }

        public void Saludar() {
            foreach (T player in _Players) {
                player.Saludar();
            }
        }
    }
}