using System.Collections;
namespace SpyfallProject.logischelaag
{
    public class Shuffle
    {
        private static readonly Random random = new();
        public static void ShuffleList(ArrayList arrayList)
        {
            //de data gaan shufflen in de array
            for (int i = 0; i < arrayList.Count - 1; i++)
            {
                int j = random.Next(i, arrayList.Count);
                Speler tempSpeler = (Speler)arrayList[i];
                arrayList[i] = arrayList[j];
                arrayList[j] = tempSpeler;
            }
        }
    }
}
