
using Spyfall.Datalaag;
using Spyfall.Globals;
using System.Collections.Generic;

namespace Spyfall.Logica
{
    public class SpyfallLogica
    {
        private readonly DataProvider dataProvider;

        public SpyfallLogica()
        {
            dataProvider = new DataProvider();
        }

        //public List<string> GetMatchingResults(string query)
        //{
        //    var matches = new List<ZipInfo>();
        //    foreach (var zipInfo in dataProvider.GemeenteLijst)
        //    {
        //        if (zipInfo.ToString().ToUpper().Contains(query.ToUpper())) matches.Add(zipInfo);
        //    }
        //    matches.Sort();
        //    var result = new List<string>();
        //    foreach (var zipInfo in matches)
        //    {
        //        result.Add(zipInfo.ToString());
        //    }
        //    return result;


        //}
    }
}
