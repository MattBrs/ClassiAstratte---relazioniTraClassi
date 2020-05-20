using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace _016_ClassiAstratte_RelazioniTraClassi {
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Quadro))]
    [System.Xml.Serialization.XmlInclude(typeof(Scultura))]
    public abstract class OperaDarte {
        protected string _titolo;
        protected string _artista;
        
        
        /// <summary>
        /// Costruttore opera d'arte generica
        /// </summary>
        /// <param name="titolo">Nome opera d'arte</param>
        /// <param name="artista">Nome artista</param>
        public OperaDarte(string titolo, string artista) {
            _titolo = titolo;
            _artista = artista;
        }
        
        
        /// <summary>
        /// Costruttore vuoto opera d'arte generica
        /// </summary>
        public OperaDarte() : this("default", "giovanni"){}
        
        
        /// <summary>
        /// Metodo astratto per calcolare area opera
        /// </summary>
        /// <returns>Restituisce l'area occupata dall'opera d'arte</returns>
        public abstract double printIngombro();
        
        
        /// <summary>
        /// Metodo per controllare se due opere d'arte sono uguali
        /// </summary>
        /// <param name="obj">Oggetto di tipo opera d'arte</param>
        /// <returns>Restituisce true se sono uguali, altrimenti false</returns>
        public bool Equals(object obj) {
            if (obj.GetType() != this.GetType()) return false;
            if (this.printIngombro() == (obj as OperaDarte).printIngombro()) return true;
            else return false;
        }
        
        
        /// <summary>
        /// Stampa lo stato interno dell'oggetto
        /// </summary>
        /// <returns>Restituisce stinga con valori interni dell'oggetto</returns>
        public override string ToString() {
            return Strings.Format($"Titolo: {_titolo}  Artista: {_artista}  ");
        }
        
        
        /// <summary>
        /// proprieta' per la variabile titolo
        /// </summary>
        public string Titolo {
            get => _titolo;
            set => _titolo = value;
        }
        
        
        /// <summary>
        /// proprieta' per la variabile artista
        /// </summary>
        public string Artista {
            get => _artista;
            set => _artista = value;
        } 
    }
}