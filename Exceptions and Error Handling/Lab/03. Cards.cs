using System;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


namespace Shapes;

public class StartUp {
  static void Main()
  {


    List<string> all_cards = Console.ReadLine().Split(", ").ToList();
    List<string> valid_card_faces = new List<string>() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
    List<string> valid_card_suits = new List<string>() {"S", "H", "D", "C"};
    List<Card> all_Cards = new List<Card>();

    for (int i=0; i < all_cards.Count; i++){

      string card = all_cards[i];

      List<string> face_suit = card.Split().ToList();

      if (!valid_card_faces.Contains(face_suit[0])){
        Console.WriteLine("Invalid card!");
      }
      else if (!valid_card_suits.Contains(face_suit[1])){
        Console.WriteLine("Invalid card!");
      }
      else{
        Card card1 = new Card(face_suit[0], face_suit[1]);
        all_Cards.Add(card1);
      }
    }


    List<string> final = new List<string>();

    foreach(var thing in all_Cards){

      final.Add(thing.ToString());

    }

    Console.WriteLine(string.Join(" ", final));

  
  }
}


public class Card{
    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    public string Face{get; set;}

  public string Suit{get; set;}

    public override string ToString()
    {
        
      if (Suit == "S"){
        return $"[{Face}\u2660]";
      }
      else if( Suit == "H"){
        return $"[{Face}\u2665]";
      }
      else if (Suit == "D"){
        return $"[{Face}\u2666]";
      }
      else if (Suit == "C"){
        return $"[{Face}\u2663]";
      }


      return "";

    }

}
