namespace EntityHw2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class hw2_context : DbContext
    {
        public hw2_context() : base("name=hw2-context") { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}