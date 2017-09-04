using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight
{
  public class ProgrammingLanguage
  {
    public ProgrammingLanguage(string name, int googleResults, int bingResults) {
      Name = name;
      GoogleResults = googleResults;
      BingResults = bingResults;
    }

    public string Name { get; set; }
    public int GoogleResults { get; set; }
    public int BingResults { get; set; }
    public int GetTotalResults => GoogleResults + BingResults;
  }
}
