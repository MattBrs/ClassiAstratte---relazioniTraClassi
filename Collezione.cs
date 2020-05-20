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

        public void Save(){
            StreamWriter sw = new StreamWriter("Museo.xml");
            Type[] tipiDiOpere = { typeof(OperaDarte), typeof(Quadro), typeof(Scultura) };
            XmlSerializer xs = new XmlSerializer(typeof(Collezione),tipiDiOpere);
            xs.Serialize(sw, this);
            sw.Close();
        }
        public Collezione LeggiXml(){
            StreamReader sr = new StreamReader("Museo.xml");
            Type[] tipiDiOpere = { typeof(OperaDarte), typeof(Quadro), typeof(Scultura) };
            XmlSerializer xs = new XmlSerializer(typeof(Collezione),tipiDiOpere);
            Collezione comodo =  (Collezione)xs.Deserialize(sr);
            sr.Close();
            return comodo;
            
        }


        public Collezione(string nome, string luogo, List<OperaDarte> opere) {
            _nome = nome;
            _luogo = luogo;
            _opere = opere;

        }

        public Collezione(string nome, string luogo) : this(nome, luogo, new List<OperaDarte>()) { }
        public Collezione() : this("default", "venezia", new List<OperaDarte>()){}

        public bool InserisciOpera(OperaDarte opera) {
            if (!_opere.Contains(opera)) {
                _opere.Add(opera);
                return true;
            }
            else return false;
        }

        public double OccupazioneOpera(string nomeOpera) {
            int pos = _opere.FindIndex(x => x.Titolo.ToLower() == nomeOpera.ToLower());
            if (pos >= 0) return _opere[pos].printIngombro();
            else return 0;
        }

        public override string ToString() {
            string tmp = string.Format($"Nome Collezione: [ {_nome} ]  Luogo: [ {_luogo} ]\n");
            _opere.ForEach(x => tmp += "- " + x.ToString() + "\n");
            return tmp;
        }


        public string Nome{
            get => _nome;
            set => _nome = value;
        }
        public string Luogo{
            get => _luogo;
            set => _luogo = value;
        }
        public List<OperaDarte> Opere{
            get => _opere;
            set => _opere = value;
        }
    }
}
