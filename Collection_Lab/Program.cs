using System.Collections;

namespace Collection_Lab
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var coll = new Collection(new int[10] { 1, 10, 20, 30, 40, 50, 60, 70, 80, 90 });
      foreach (var item in coll)
      {
        Console.WriteLine(item);
      }
    }

    public class Collection : IEnumerable<int>
    {
      private int[] _coll;
      public Collection(int[]coll)
      {
        _coll = coll;
      }
      public IEnumerator<int> GetEnumerator()
      {
        for (int i = 0; i < _coll.Length; ++i)
        {
          if (i == _coll.Length - 1) yield break;
          else yield return _coll[i] + _coll[i + 1];          
        }
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return _coll.GetEnumerator();
      }
    }
  }
}