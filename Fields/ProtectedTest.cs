using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
  internal class User
  {
    internal static readonly string mainAdministrator = "The Administrator";
    internal readonly string commonAdmin = "Admin Common";
    private protected int numberOfUser = 100;
  }

  internal class Owner : User
  {
    internal string ownerNo1 = "Jun";
    void TryToAccess() {
      User X = new User();
      /*Console.WriteLine(X.numberOfUser);*/ // protected error
      Console.WriteLine(numberOfUser);
    }
  }
}
