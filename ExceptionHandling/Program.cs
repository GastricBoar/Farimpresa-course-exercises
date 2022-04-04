using System;

namespace ExceptionHandling
{
    /// <summary>
    /// Manage Exception
    /// </summary>
    class Program
    {
        /// <summary>
        /// tcp - http - https -> error 500: errore generico
        /// 200 -> ok, tutto va bene
        /// 404 not found
        /// 400 bad request -> richiesta non accettata
        /// 302 forbidden -> errore momentaneo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            char op;
            decimal res = 0;

            //Inizio logica
            try //prova a eseguire il codice dentro le parentesi
            {
                Console.WriteLine("Inserisci i due valori per eseguire le operazioni: ");
                Console.WriteLine("Inserisci il primo numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                res = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Il risultato è: " + res);
            }
            catch(FormatException formatException)
            {

            }            
            catch (DivideByZeroException divideException) //Cattura l'errore, nel caso il server non risponde
            {
                //logerror(ex.message);

                //Se sei entrato qui dentro, scrivi nel file di log il messaggio di errore, ma mostra all'utente un messaggio di attesa
                Console.WriteLine("Ciao, potresti per piacere dividere il secondo numero inserendo un valore maggiore di zero?");

                Console.WriteLine("Inserisci il secondo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if(num2 <= 0)
                {
                    Console.WriteLine("Ciao, potresti per piacere dividere il secondo numero inserendo un valore maggiore di zero?");

                    Console.WriteLine("Inserisci il secondo numero: ");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            { //chiudi la connessione al database

            }

            //Fine logica
        }
    }
}
