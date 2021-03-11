using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book bk, int qty)
        {
            CartLine line = Lines.Where(b => b.Book.BookID == bk.BookID).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bk,
                    Quantity = qty,
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book bk) => Lines.RemoveAll(x => x.Book.BookID == bk.BookID);

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => Lines.Sum(e => e.Quantity * (decimal)e.Book.Price);

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
