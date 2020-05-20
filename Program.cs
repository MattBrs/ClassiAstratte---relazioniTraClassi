using System;

namespace _016_ClassiAstratte_RelazioniTraClassi {
    class Program {
        static void Main(string[] args) {
            OperaDarte q1 = new Quadro("quadro 1", "matteo", 12, 10);
            OperaDarte q2 = new Quadro("quadro 2", "cristian", 12, 10);
            OperaDarte s1 = new Scultura("scultura 1", "matteo", 10, 14,10);
            OperaDarte s2 = new Scultura("scultura 2", "luca", 4, 6,23);

            Console.WriteLine(q1.printIngombro());
            Console.WriteLine(q2.printIngombro());   //stampo gli ingombri
            Console.WriteLine(s1.printIngombro());
            Console.WriteLine(s2.printIngombro());
            
            Console.WriteLine("\n");
            
            Console.WriteLine(q1);
            Console.WriteLine(q2);                   //stampo le informazioni
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
            Console.WriteLine("\n");
            
            //Controllo se hanno lo stesso ingombro e stampo il risultato
            if(q1.Equals(s1)) Console.WriteLine(q1.Titolo + " e " +s1.Titolo + " occupano lo stesso spazio");
            else Console.WriteLine(q1.Titolo + " e " + s1.Titolo + " occupano spazi diversi");
            
            if(q1.Equals(q2)) Console.WriteLine(q1.Titolo + " e " + q2.Titolo +  " occupano lo stesso spazio");
            else Console.WriteLine(q1.Titolo + " e " + q2.Titolo + " occupano spazi diversi");

            Console.WriteLine("\n");
            
            //creo la collezione di opere
            Collezione c1 = new Collezione("Collezione 1", "vicenza");
            
            //aggiungo le opere alla collezione
            c1.InserisciOpera(q1);
            c1.InserisciOpera(q2);
            c1.InserisciOpera(s1);
            c1.InserisciOpera(s2);
            //ne metto una che ho gia' messo per controllare se la aggiunge
            c1.InserisciOpera(q1);
            
            //stampo la collezione
            Console.WriteLine(c1);
            
            //cerco opera e stampo ingombro. Se e' 0 vuol dire che l'opera non e' presente nella collezione
            double tmp = c1.OccupazioneOpera("quadro 1");
            if(tmp != 0) Console.WriteLine("L'opera occupa: " + tmp);
            else Console.WriteLine("l'opera non e' presete in memoria");

            c1.Save();
            Collezione c2 = new Collezione("prova", "schio");
            Console.WriteLine("\nDati letti da file xml");
            Console.WriteLine(c2.LeggiXml().ToString());
        }
    }
}