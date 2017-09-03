﻿namespace SearchFight
{
  interface ISearchProvider<T> where T:class
  {
    T Search(string query);
  }
}
