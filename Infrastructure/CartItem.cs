using UKW_sklep.czw.Models;

namespace UKW_sklep.czw.Infrastructure
{
    public class CartItem
    {
        public Film? Film { get; set; }
        public int Quantity { get; set; }
        public decimal? Value { get; set; }
    }
}
