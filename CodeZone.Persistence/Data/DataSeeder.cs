using CodeZone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Persistence.Data
{
    internal static class DataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Item> items = new List<Item> 
            {
                new Item{ Id = 1 , Name = "Apple" , Image = "images/items/apple" },
                new Item{ Id = 2 , Name = "Banana" , Image = "images/items/banana" },
                new Item{ Id = 3 , Name = "Cherry" , Image = "images/items/cherry" },
                new Item{ Id = 4 , Name = "Date" , Image = "images/items/date" },
                new Item{ Id = 5 , Name = "Elderberry" , Image = "images/items/elderberry" },
                new Item{ Id = 6 , Name = "Fig" , Image = "images/items/fig" },
                new Item{ Id = 7 , Name = "Grape" , Image = "images/items/grape" },
                new Item{ Id = 8 , Name = "Honeydew" , Image = "images/items/honeydew" },
            };

            List<Store> stores = new List<Store>
            {
                new Store{Id = 1 , Name = "Cairo"},
                new Store{Id = 2 , Name = "Alexandria"},
                new Store{Id = 3 , Name = "Giza"},
                new Store{Id = 4 , Name = "Suez"},
                new Store{Id = 5 , Name = "Mansoura"},

                };

            List<StoreItem> storeItems = new List<StoreItem>
            {
                new StoreItem{ItemId = 1 , StoreId = 1 , Quantity = 10},
                new StoreItem{ItemId = 1 , StoreId = 3 , Quantity = 9},
                new StoreItem{ItemId = 2 , StoreId = 2 , Quantity = 43},
                new StoreItem{ItemId = 3 , StoreId = 2 , Quantity = 30},
                new StoreItem{ItemId = 3 , StoreId = 5 , Quantity = 7},
                new StoreItem{ItemId = 3 , StoreId = 1 , Quantity = 16},
                new StoreItem{ItemId = 4 , StoreId = 3 , Quantity = 40},
                new StoreItem{ItemId = 4 , StoreId = 5 , Quantity = 81},
                new StoreItem{ItemId = 5 , StoreId = 2 , Quantity = 66},
                new StoreItem{ItemId = 5 , StoreId = 5 , Quantity = 32},
                new StoreItem{ItemId = 6 , StoreId = 2 , Quantity = 60},
                new StoreItem{ItemId = 6 , StoreId = 3 , Quantity = 4},
                new StoreItem{ItemId = 7 , StoreId = 1 , Quantity = 45},
                new StoreItem{ItemId = 8 , StoreId = 1 , Quantity = 54},
            };


            modelBuilder.Entity<Item>().HasData(items);
            modelBuilder.Entity<Store>().HasData(stores);
            modelBuilder.Entity<StoreItem>().HasData(storeItems);
        }
    }
}
