using UKW_sklep.czw.DAL;
using UKW_sklep.czw.Infrastructure;
namespace UKW_sklep.czw.Infrastructure
{
    public class CartManager
    {
        public static List<CartItem> GetItems(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(session, Consts.CartKey);
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            return cart;
        }
        public static decimal? GetCartValue(ISession session)
        {
            var cart = GetItems(session);
            return cart.Sum(c => c.Value * c.Quantity);
        }
        public static void AddToCart(ISession session, int filmId, FilmsContext db)
        {
            var cart = GetItems(session);
            var newCartItem = cart.Find(c => c.Film.Id_Film == filmId);
            if (newCartItem != null)
            {
                newCartItem.Quantity++;
            }
            else
            {
                var film = db.FilmContex.Find(filmId);
                if (film != null)
                {
                    newCartItem = new CartItem()
                    {
                        Film = film,
                        Quantity = 1,
                        Value = film.Price
                    };
                    cart.Add(newCartItem);
                }

            }
            SessionHelper.SetObjectAsJson(session, cart, Consts.CartKey);

        }

        public static int RemoveFromCart(ISession session, int Id_film)
        {
            var cart = GetItems(session);
            var thisFilm = cart.Find(i => i.Film.Id_Film == Id_film);
            int ilosc = 0;
            if (thisFilm == null)
            {
                return 0;
            }
            if (thisFilm.Quantity > 1)
            {
                thisFilm.Quantity--;
                ilosc = thisFilm.Quantity;
            }
            else
            {
                cart.Remove(thisFilm);
            }
            session.SetObjectAsJson(cart, Consts.CartKey);
            return ilosc;
        }
    }
}

