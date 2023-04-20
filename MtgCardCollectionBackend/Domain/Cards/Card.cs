using MtgCardCollectionBackend.Domain.ManaCosts;

namespace MtgCardCollectionBackend.Domain.Cards;

public class Card
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Set { get; set; }
    public Uri FetchUrl { get; set; }
    public ManaCost ManaCost { get; set; }

    public Card(int id, string name, string set, Uri url, ManaCost manaCost)
    {
        Id = id;
        Name = name;
        Set = set;
        FetchUrl = url;
        ManaCost = manaCost;
    }
}
