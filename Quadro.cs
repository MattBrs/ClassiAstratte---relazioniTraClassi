namespace _016_ClassiAstratte_RelazioniTraClassi {
    public class Quadro : OperaDarte {
        private double _altezza;
        private double _larghezza;
        
        
        /// <summary>
        /// Costruttore per opera d'arte di tipo quadro
        /// </summary>
        /// <param name="titolo">Nome opera</param>
        /// <param name="artista">Nome artista</param>
        /// <param name="altezza">Altezza opera d'arte</param>
        /// <param name="larghezza">Larghezza opera d'arte</param>
        public Quadro(string titolo, string artista, double altezza, double larghezza) : base(titolo, artista) {
            _altezza = altezza;
            _larghezza = larghezza;
        }
        
        /// <summary>
        /// Costruttore vuoto per opera d'arte di tipo quadro
        /// </summary>
        public Quadro() : this("default", "default", 12, 43){}
        
        /// <summary>
        /// Calcola l'areo occupata dall'opera d'arte
        /// </summary>
        /// <returns>Restituisce l'area dell'opera d'arte</returns>
        public override double printIngombro() {
            return _altezza * _larghezza;
        }
        
        
        /// <summary>
        /// Stampa lo stato interno dell'oggetto
        /// </summary>
        /// <returns>Restituisce stringa con le informazioni dll'oggetto</returns>
        public override string ToString() {
            return base.ToString() + $"Altezza: {_altezza}  Larghezza: {_larghezza}";
        }
        
        /// <summary>
        /// Proprieta' per la variabile altezza
        /// </summary>
        public double Altezza {
            get => _altezza;
            set => _altezza = value;
        } 
        
        /// <summary>
        /// Proprieta' per la variabile larghezza
        /// </summary>
        public double Larghezza {
            get => _larghezza;
            set => _larghezza = value;
        } 
    }
}