using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
  public class Professor : Client
  {
    public string Email { get; set; }

    public Professor()
    {
    }

    public Professor(string name, int nif, float balance, string email) : base(name, nif, balance)
    {
      Email = email;
    }
  }
}
