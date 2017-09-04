namespace SearchFight
{
  public interface ISearchProvider<T> where T:class
  {
    T Search(string query);
  }
}
