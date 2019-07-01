using System;
using System.Collections.Generic;

namespace dcg.Models
{
  public class Deck
  {
    public List<Card> cards = new List<Card>();
    public int size = 99;
    // 33 cards total
    public string[] action = 
    {
      // Compete
      "The person after you can ask any questions. You can either answer truthfully or refuse and drink.",
      "Imitate another player. First person to guess correctly picks someone to drink.",
      "Pick someone and guess the color of their underwear. If you guess correctly they drink, otherwise you drink.",
      "Starting with you, take turns naming a color. Continue until someone hesitates or repeats a color. That person drinks.",
      "Starting with you, take turns naming STD's. Continue until somoene hesitates or repeats. That person drinks.",
      "Pick a word. Everyone takes turn saying a word that rhymes. The person that hesitates or repeats a word drinks.",
      "Flip a coin. If it's heads you drink. If it's tails, everyone else drinks.",
      "Challenge another player to a thumb war. Loser drinks.",
      // Votes
      "Everyone votes on who is the most indecisive. That person drinks.",
      "Everyone votes on who is the biggest alcoholic. That person drinks and also picks another person to drink.",
      "Everyone votes on who is most likely to dodge drinks. That person drinks.",
      "Everyone votes on who is mostlikely to own 10 cats. That person drinks.",
      "Which player got a tattoo most recently? Drink and show everyone your new ink.",
      "Which would you rather give up, oral sex or cheese? Everyone votes; the losing team drinks.",
      "Everyone wearing a shirt with a button drinks.",
      "Everyone who posted a picture on social media in the past month drinks.",
      // Fun
      "You have 30 seconds to make the person on your right laugh. If you fail, you drink. If you succeed, they drink.",
      "You must say 'I love drinking' in another language. If you cannot drink.",
      "Everyone who has failed a driving test (or has never taken one) drinks.",
      "Every player who's a scorpio drinks. Your parents probably fucked on Valentine's Day. Ever think of that?",
      "Every player takes a drink for each year they had braces.",
      "Drink if you've ever secretly thrown up at a party and then acted like nothing ever happened.",
      "Take a drink if you've ever given or recieved road head. Don't like you kinky bastards.",
      "Everyone who is single drinks.",
      "The person who most recently used the bathroom drinks.",
      "You drink.",
      "Everyone who is shorter than you drinks.",
      "Everyone but you drinks.",
      "If you're in a relationship your partner drinks. If you're single, you drink.",
      "Pick another person to drink as much as your drink as they please. You must finish the rest.",
      "Drink if your parents bought you a car in high school.",
      "Drink if you're in a serious relationship - one drink for each year you've been dating your significant other.",
      "The next player you make eye contact with takes a drink."
    };

    public Deck()
    {
      CreateDeck();
    }
    
    public void Rebuild()
    {
      cards.Clear();
      CreateDeck();
    }

    public void CreateDeck()
    {
      for(int i = 0; i < size; i++)
      {
        Card cardToAdd = new Card(
          action[i % 33]
        );
        cards.Add(cardToAdd);
      }
    }

    public Card Deal()
    {
      Card deal = cards[0];
      cards.RemoveAt(0);
      return deal;
    }

    public void Shuffle()
    {
      if(cards.Count < size)
        Rebuild();
      for(int i = 0; i < size; i++)
      {
        Random rand = new Random();
        int random = rand.Next(size);
        Card temp = cards[i];
        cards[i] = cards[random];
        cards[random] = temp;
      }
    }


  }
}