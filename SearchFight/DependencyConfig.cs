using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight
{
  public static class DependencyConfig
  {
    public static ServiceContainer Container { get; set; }

    public static void Configure() {
      Container = new ServiceContainer();
      Container.Register<ISearchProvider<GoogleCustomSearchResponse>, GoogleSearchProvider>("GoogleSearchProvider");
      Container.Register<ISearchProvider<BingWebSearchResponse>, BingSearchProvider>("BingSearchProvider");
      Container.Register<ISearchService, SearchService>();
    }
  }
}
