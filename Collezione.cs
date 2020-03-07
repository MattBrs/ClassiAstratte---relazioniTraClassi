using System.Collections.Generic;
using System.Net.Http;

namespace _016_ClassiAstratte_RelazioniTraClassi {
    public class Collezione {
        private string _nome;
        private string _luogo;
        private List<OperaDarte> _opere;

        public Collezione(string nome, string luogo, List<OperaDarte> opere) {
            _nome = nome;
            _luogo = luogo;
            _opere = opere;
        }

        public Collezione(string nome, string luogo) : this(nome, luogo, new List<OperaDarte>()) {
        }

        public bool InserisciOpera(OperaDarte opera) {
            if (!_opere.Contains(opera)) {
                _opere.Add(opera);
                return true;
            }
            else return false;
        }

        public double OccupazioneOpera(string nomeOpera) {
            int pos = _opere.FindIndex(x => x.Nome.ToLower() == nomeOpera.ToLower());
            if (pos >= 0) return _opere[pos].printIngombro();
            else return 0;
        }

        public override string ToString() {
            string tmp = string.Format($"Nome Collezione: [ {_nome} ]  Luogo: [ {_luogo} ]\n");
            _opere.ForEach(x => tmp += "- " + x.ToString() + "\n");
            return tmp;
        }
    }
}