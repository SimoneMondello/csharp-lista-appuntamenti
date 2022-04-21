// See https://aka.ms/new-console-template for more information


using ListaAppuntamenti;

Console.WriteLine("Inserisci il nome");

DateTime dataOraAttuale = DateTime.Now;

Console.WriteLine();

Console.Write("Inserisci una data: ");
string dataInserita = Console.ReadLine();

DateTime dataUtente = DateTime.Parse(dataInserita);

if(dataUtente > dataOraAttuale)
{
    Console.WriteLine("Prenotazione effettuata, a presto!");
} else if(dataUtente == dataOraAttuale)
{
    Console.WriteLine("Non è possibile prenotare oggi");
} else
{
    Console.WriteLine("La data che hai inserito sta nel passato");
}


Console.WriteLine("Inserisci il tuo nome e cognome:");
string nome = Console.ReadLine();
Console.WriteLine("Inserisci dove vuoi incontrarti:");
string localita = Console.ReadLine();
Console.WriteLine("Inserisci la data dell'appuntamento");
double tempo = double.Parse(Console.ReadLine());

List<Appuntamento> listaApp = new List<Appuntamento>();

// Creo i miei prodotti
Appuntamento prodotto1 = new Appuntamento(nome, (int)tempo , localita);


// Aggiungo i miei prodotti alla lista!
listaApp.Add(prodotto1);



// STAMPIAMO LA LISTA DI PRODOTTI
Console.WriteLine("Stampiamo la lista di PRODOTTI");

foreach (Appuntamento prodottoNellaLista in listaApp)
{
    Console.WriteLine(prodottoNellaLista.ToString());
}
