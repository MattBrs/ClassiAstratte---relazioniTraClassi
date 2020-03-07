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

        public override double printIngombro() {
            return _altezza * _larghezza * _profondita;
        }

        public override string ToString() {
            return base.ToString() + $"Altezza: {_altezza}  Larghezza: {_larghezza}  Profondita': {_profondita}";
        }
    }
}