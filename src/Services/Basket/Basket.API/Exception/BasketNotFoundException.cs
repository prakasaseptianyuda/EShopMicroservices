using BuildingBlocks.Exceptions;

namespace Basket.API.Exception
{
    public class BasketNotFoundException : NotFoundException
    {
        public BasketNotFoundException(string userName) : base("basket", userName)
        {
            
        }
    }
}
