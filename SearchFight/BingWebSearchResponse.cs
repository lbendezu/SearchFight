namespace SearchFight
{
  public class BingWebSearchResponse
  {
    public BingWebPages WebPages { get; set; }
  }

  public class BingWebPages
  {
    public int TotalEstimatedMatches { get; set; }
  }
}