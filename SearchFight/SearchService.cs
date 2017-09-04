namespace SearchFight
{
  public class SearchService : ISearchService
  {
    private ISearchProvider<GoogleCustomSearchResponse> googleProvider;
    private ISearchProvider<BingWebSearchResponse> bingProvider;

    public SearchService(ISearchProvider<GoogleCustomSearchResponse> googleProvider, ISearchProvider<BingWebSearchResponse> bingProvider)
    {
      this.googleProvider = googleProvider;
      this.bingProvider = bingProvider;
    }

    public ProgrammingLanguage GetSearchResults(string query){
      var googleResponse = googleProvider.Search(query);
      var bingResponse = bingProvider.Search(query);

      return new ProgrammingLanguage(query, googleResponse.SearchInformation.TotalResults, bingResponse.WebPages.TotalEstimatedMatches);
    }

  }
}
