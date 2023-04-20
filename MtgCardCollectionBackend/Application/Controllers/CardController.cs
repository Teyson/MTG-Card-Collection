using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DomainCard = MtgCardCollectionBackend.Domain.Cards.Card;
using ScryfallApi.Client;
using ScryfallCard = ScryfallApi.Client.Models.Card;
using ScryfallApi.Client.Models;

namespace MtgCardCollectionBackend.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ScryfallApiClient ScryfallApiClient;

        public CardController(ScryfallApiClient scryfallApiClient)
        {
            ScryfallApiClient = scryfallApiClient;
        }

        //public DomainCard SearchNamedCard(string cardName)
        //{
        //    ResultList<ScryfallCard> results = null;
        //    do
        //    {
        //        ScryfallApiClient.Cards.Search(cardName);

        //    }
        //    while () { }
        //}
    }
}
