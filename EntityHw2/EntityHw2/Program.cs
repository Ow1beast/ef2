using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHw2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new hw2_context())
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Login = "Login1",
                    Password = "Pass1"
                };

                var cart = new Cart
                {
                    Id = Guid.NewGuid()
                };

                user.Cart = cart;

                var item = new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Name1",
                    Price = 300,
                    Carts = new List<Cart>
                    {
                        cart
                    }
                };

                cart.Items = new List<Item>
                {
                    item
                };

                context.Carts.Add(cart);
                context.Users.Add(user);
                context.Items.Add(item);

                context.SaveChanges();
            }
        }
    }
}
