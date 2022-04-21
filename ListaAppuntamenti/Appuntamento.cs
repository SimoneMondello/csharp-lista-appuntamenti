using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 In questo esercizio vogliamo creare una sorta di nostra agenda
 personale dove vogliamo salvare i nostri futuri appuntamenti. 
 Per tanto il programma si dovrà occupare di salvare le informazioni in una lista di appuntamenti.
A tale scopo dovremmo creare una classe Appuntamento 
che si occupa di salvare e gestire (costruttore e metodi opportuni) eventuali appuntamenti.
La classe Appuntamento avrà:
un attributo data e ora (DateTime)
un attributo nome
un attributo localitaAppuntamento
un costruttore che inizializza tutti i campi di Appuntamento,
ma che controlli che un Appuntamento non venga aggiunto nel passato, cioè prima di oggi. Nel caso lancia un’eccezione.
un metodo per cambiare la Data dell’appuntamento dove riceverà un nuovo oggetto di tipo DateTime. Il metodo dovrà occuparsi di lanciare opportune eccezioni nel caso in cui la data sia antecedente ad oggi.
Tutti gli eventuali altri Getters e Setters
A questo punto nel programma principale Program.cs creiamo una Lista di
Appuntamenti vuota e chiediamo all’utente quanti appuntamenti vuole inserire. Per ogni appuntamento chiediamo le informazioni necessarie e inizializziamo un oggetto Appuntamento, stando attenti a gestire eventuali eccezioni, ossia se uno sbaglia quell'appuntamento deve essere ri-richiesto. Inseriamo l’oggetto appuntamento correttamente inizializzato nella lista.
Alla fine stampate in maniera user-friendly (usando possibilmente l'override del metodo ToString(); della classe Object) la lista dei vostri appuntamenti futuri.
*/


namespace ListaAppuntamenti

{
    internal class Appuntamento
    {

        private string nome;
        private string localitaAppuntamento;
        private int tempo;
        private double tempo1;
        private string? localita;

        public Appuntamento(string nome, int tempo, string localitaAppuntamento)
        {
            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
            this.tempo = tempo;
        }

        public Appuntamento(string? nome, double tempo1, string? localita)
        {
            this.nome = nome;
            this.tempo1 = tempo1;
            this.localita = localita;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetLocalita()
        {
            return localitaAppuntamento;
        }
        public double GetTempo()
        {
            
            return tempo;
        }

        public string ToString()
        {
            string rappresentazioneInStringa = "";

            rappresentazioneInStringa += "---- Appuntamento ---- \n";
            rappresentazioneInStringa += "Nome: " + this.nome + "\n";
            rappresentazioneInStringa += "Data: " + this.tempo + "\n";
            rappresentazioneInStringa += "Località: " + this.localitaAppuntamento + "\n";


            return rappresentazioneInStringa;


        }

    }
}
