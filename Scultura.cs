namespace _016_ClassiAstratte_RelazioniTraClassi {
    public class Scultura : OperaDarte {
        private double _altezza;
        private double _larghezza;
        private double _profondita;

        public Scultura(string titolo, string artista, double altezza, double larghezza, double profondita) : base(
            titolo, artista) {
            _altezza = altezza;
            _larghezza = larghezza;
            _profondita = profondita;
        }
        public Scultura(): this("default", "default", 5,12,32){}
        public override double printIngombro() {
            return _altezza * _larghezza * _profondita;
        }

        public override string ToString() {
            return base.ToString() + $"Altezza: {_altezza}  Larghezza: {_larghezza}  Profondita': {_profondita}";
        }

        public double Altezza {
            get => _altezza;
            set => _altezza = value;
        } 
        public double Larghezza {
            get => _larghezza;
            set => _larghezza = value;
        } 
        public double Profondita {
            get => _profondita;
            set => _profondita = value;
        } 

    }
}