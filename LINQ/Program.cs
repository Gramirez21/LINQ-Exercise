namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <string> cardGames = new List <string> ();

            cardGames.Add("Poker");
            cardGames.Add("31");
            cardGames.Add("21");
            cardGames.Add("Texas hold em");

            cardGames.OrderBy(x => x.Length).ToList ().ForEach(x => Console.WriteLine (x));
            

        }
    }
}
