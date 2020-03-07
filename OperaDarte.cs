using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace _016_ClassiAstratte_RelazioniTraClassi {
    public abstract class OperaDarte {
        protected string _titolo;
        protected string _artista;

        public OperaDarte(string titolo, string artista) {
            _titolo = titolo;
            _artista = artista;
        }

        public abstract double printIngombro();

        public bool Equals(object obj) {
            if (obj.GetType() != this.GetType()) return false;
            if (this.printIngombro() == (obj as OperaDarte).printIngombro()) return true;
            else return false;
        }

        public override string ToString() {
            return Strings.Format($"Titolo: {_titolo}  Artista: {_artista}  ");
        }

        public string Nome {
            get => _titolo;
        }
    }
}