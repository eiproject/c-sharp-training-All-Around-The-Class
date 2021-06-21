using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
  internal class User
  {
    internal static readonly string mainAdministrator = "The Administrator";
    internal readonly string commonAdmin = "Admin Common";
    internal protected int numberOfUser = 100;
    private protected int numberOfAdmin = 10;
    private int numberOfAccount = 110;
    protected int numberOfApple = 5;
  }

  internal class Owner : User
  {
    internal string ownerNo1 = "Jun";
    internal void TryToAccess() {
      User X = new User();
      /*Console.WriteLine(X.numberOfAdmin); // private, error
      Console.WriteLine(X.numberOfAccount); // private, error
      Console.WriteLine(X.numberOfUser); // internal, OK
      Console.WriteLine(X.numberOfApple); // internal, OK*/
      Console.WriteLine("numberOfUser: " + numberOfUser.ToString());
      Console.WriteLine("numberOfAdmin: " + numberOfAdmin.ToString()); // protected. allow access in the child
      /*Console.WriteLine("numberOfAccount: " + numberOfAccount.ToString()); // private, error*/
      Console.WriteLine("numberOfAccount: " + numberOfApple.ToString()); // protected, OK for this child
    }
  }
}
