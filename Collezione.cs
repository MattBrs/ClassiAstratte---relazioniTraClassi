using System.Collections.Generic;
using System.Net.Http;
using System.IO;
using System.Xml.Serialization;
using System;

namespace _016_ClassiAstratte_RelazioniTraClassi {

    [Serializable]
    public class Collezione {
        private string _nome;
        private string _luogo;
        private List<OperaDarte> _opere;
        
        
        /// <summary>
        /// Metodo per salvare su disco un file in formato XML
        /// </summary>
        public void Save(){
            StreamWriter sw = new StreamWriter("Museo.xml");
            Type[] tipiDiOpere = { typeof(OperaDarte), typeof(Quadro), typeof(Scultura) };
            XmlSerializer xs = new XmlSerializer(typeof(Collezione),tipiDiOpere);
            xs.Serialize(sw, this);
            sw.Close();
        }
        
        /// <summary>
        /// Metodo per leggere da disco un file di tipo XML e salvarlo su variabile
        /// </summary>
        /// <returns>Restituisce una collezione di opere</returns>
        public Collezione LeggiXml(){
            StreamReader sr = new StreamReader("Museo.xml");
            Type[] tipiDiOpere = { typeof(OperaDarte), typeof(Quadro), typeof(Scultura) };
            XmlSerializer xs = new XmlSerializer(typeof(Collezione),tipiDiOpere);
            Collezione comodo =  (Collezione)xs.Deserialize(sr);
            sr.Close();
            return comodo;
            
        }

        /// <summary>
        /// Costruttore per la collezione di opere
        /// </summary>
        /// <param name="nome">Nome collezione</param>
        /// <param name="luogo">Nome localita' della collezione</param>
        /// <param name="opere">Lista di opere d'arte</param>
        public Collezione(string nome, string luogo, List<OperaDarte> opere) {
            _nome = nome;
            _luogo = luogo;
            _opere = opere;

        }
        
        /// <summary>
        /// Costruttore secondario per la collezione di opere d'arte
        /// </summary>
        /// <param name="nome">Nome collezione</param>
        /// <param name="luogo">Nome localita' della collezione</param>
        public Collezione(string nome, string luogo) : this(nome, luogo, new List<OperaDarte>()) { }
        
        /// <summary>
        /// Costruttore vuoto per la collezione
        /// </summary>
        public Collezione() : this("default", "venezia", new List<OperaDarte>()){}
        
        /// <summary>
        /// Metodo per inserire nella collezione un'opera
        /// </summary>
        /// <param name="opera">Oggetto opera d'arte</param>
        /// <returns>ritorna un valore booleano per confermare l'inerimento</returns>
        public bool InserisciOpera(OperaDarte opera) {
            if (!_opere.Contains(opera)) {
                _opere.Add(opera);
                return true;
            }
            else return false;
        }
        
        /// <summary>
        /// Metodo per trovare la posizione di un opera nella lista
        /// </summary>
        /// <param name="nomeOpera">Nome opera da cercare</param>
        /// <returns>Restituisce la posizione dell'opera nella lista</returns>
        public double OccupazioneOpera(string nomeOpera) {
            int pos = _opere.FindIndex(x => x.Titolo.ToLower() == nomeOpera.ToLower());
            if (pos >= 0) return _opere[pos].printIngombro();
            else return 0;
        }
        
        /// <summary>
        /// Stampa lo stato interno dell'oggetto
        /// </summary>
        /// <returns>Restituisce stringa con le informazioni dll'oggetto</returns>
        public override string ToString() {
            string tmp = string.Format($"Nome Collezione: [ {_nome} ]  Luogo: [ {_luogo} ]\n");
            _opere.ForEach(x => tmp += "- " + x.ToString() + "\n");
            return tmp;
        }

        /// <summary>
        /// proprieta' per la variabile nome
        /// </summary>
        public string Nome{
            get => _nome;
            set => _nome = value;
        }
        
        /// <summary>
        /// proprieta' per la variabile luogo
        /// </summary>
        public string Luogo{
            get => _luogo;
            set => _luogo = value;
        }
        
        /// <summary>
        /// proprieta' per la lista di opere
        /// </summary>
        public List<OperaDarte> Opere{
            get => _opere;
            set => _opere = value;
        }
    }
}
