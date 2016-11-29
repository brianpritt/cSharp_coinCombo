using System;
using System.Collections.Generic;

namespace Coins.Objects
{
  public class Coin
  {
    private int _cents;
    private Dictionary<string, int> _change = new Dictionary<string, int> ();

    public Coin(int cents)
    {
      _cents = cents;
      _change.Add("Quarters", 0);
      _change.Add("Dimes", 0);
      _change.Add("Nickels", 0);
      _change.Add("Pennies", 0);
    }
    public void MakePennies()
    {
      if(_cents>0)
      {
        int pennyChange = _cents;
        _change["Pennies"] = pennyChange;
      }
    }
    public void MakeNickels()
    {
      if(_cents>=5)
      {
        int nickelChange = _cents/5;
        _cents = _cents % 5;
        _change["Nickels"] = nickelChange;
      }
    }
    public void MakeDimes()
    {
      if(_cents>=10)
      {
        int dimeChange = _cents/10;
        _cents = _cents % 10;
        _change["Dimes"] = dimeChange;
      }
    }
    public void MakeQuarters()
    {
      if(_cents>=25)
      {
        int quarterChange = _cents/25;
        _cents = _cents % 25;
        _change["Quarters"] = quarterChange;
      }
    }
    public Dictionary<string, int> MakeChange()
    {
      MakeQuarters();
      MakeDimes();
      MakeNickels();
      MakePennies();
      return _change;
    }
  }
}
