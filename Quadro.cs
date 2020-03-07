namespace _016_ClassiAstratte_RelazioniTraClassi {
    public class Quadro : OperaDarte {
        private double _altezza;
        private double _larghezza;

        public Quadro(string titolo, string artista, double altezza, double larghezza) : base(titolo, artista) {
            _altezza = altezza;
            _larghezza = larghezza;
        }

        public override double printIngombro() {
            return _altezza * _larghezza;
        }

        public override string ToString() {
            return base.ToString() + $"Altezza: {_altezza}  Larghezza: {_larghezza}";
        }
    }
}