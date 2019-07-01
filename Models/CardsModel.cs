using System;

namespace dcg.Models
{
  public class Card
  {
    public string Action { get; set; }

    public Card(string action)
    {
      Action = action;
    }
  }
}