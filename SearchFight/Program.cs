using System;
using LightInject;
using System.Collections.Generic;
using System.Linq;

namespace SearchFight
{
  class Program
  {
    static void Main(string[] args)
    {
      DependencyConfig.Configure();

      var searchService = DependencyConfig.Container.GetInstance<ISearchService>();
      var programmingLanguages = new List<ProgrammingLanguage>();

      for (int i = 0; i < args.Length; i++)
      {
        programmingLanguages.Add(searchService.GetSearchResults(args[i]));
      }

      programmingLanguages.ForEach(pl => Console.WriteLine(string.Format("{0}: Google: {1} Bing Search: {2}", pl.Name, pl.GoogleResults, pl.BingResults)));

      Console.WriteLine("Google Winner: {0}", programmingLanguages.OrderByDescending(pl => pl.GoogleResults).FirstOrDefault().Name);
      Console.WriteLine("Bing Winner: {0}", programmingLanguages.OrderByDescending(pl => pl.BingResults).FirstOrDefault().Name);
      Console.WriteLine("Total Winner: {0}", programmingLanguages.OrderByDescending(pl => pl.GetTotalResults).FirstOrDefault().Name);

      Console.ReadKey();
    }
  }
}
