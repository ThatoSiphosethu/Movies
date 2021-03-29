using System;
using Newtonsoft.Json;

namespace Movies
{
    public static class imovies //: Actions
    {
        Series series = new Series()
        {
            ID = 1,
            Title = "Spidy",
            Season = "two"

        } 
            string strResultJson = JsonConvert.SerializeObject(series);
            File.WriteAllText(@"",);
            Console.WriteLine(strResultJson);

            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"");
            JsonConvert.DeserializeObject<>();
        }
}