namespace _016_ClassiAstratte_RelazioniTraClassi {
    public class Scultura : OperaDarte {
        private double _altezza;
        private double _larghezza;
        private double _profondita;
        
        
        /// <summary>
        /// Costruttore per un'opera d'arte di tipo scultura
        /// </summary>
        /// <param name="titolo">Nome opera</param>
        /// <param name="artista">Nome artista</param>
        /// <param name="altezza">Altezza opera</param>
        /// <param name="larghezza">Larghezza opera</param>
        /// <param name="profondita">Profondita' opera</param>
        public Scultura(string titolo, string artista, double altezza, double larghezza, double profondita) : base(
            titolo, artista) {
            _altezza = altezza;
            _larghezza = larghezza;
            _profondita = profondita;
        }
        
        
        /// <summary>
        /// costruttore vuoto scultura
        /// </summary>
        public Scultura(): this("default", "default", 5,12,32){}
        
        
        
        /// <summary>
        /// Calcola il volume del scultura
        /// </summary>
        /// <returns>Restituisce ingombro scultura</returns>
        public override double printIngombro() {
            return _altezza * _larghezza * _profondita;
        }
        
        
        /// <summary>
        /// Stampa lo stato interno dell'oggetto
        /// </summary>
        /// <returns>Restituisce stringa con le informazioni dll'oggetto</returns>
        public override string ToString() {
            return base.ToString() + $"Altezza: {_altezza}  Larghezza: {_larghezza}  Profondita': {_profondita}";
        }
        
        
        /// <summary>
        /// proprieta' per altezza
        /// </summary>
        public double Altezza {
            get => _altezza;
            set => _altezza = value;
        } 
        
        /// <summary>
        /// proprieta' per larghezza
        /// </summary>
        public double Larghezza {
            get => _larghezza;
            set => _larghezza = value;
        } 
        
        /// <summary>
        /// proprieta' per profondita'
        /// </summary>
        public double Profondita {
            get => _profondita;
            set => _profondita = value;
        } 

    }
}