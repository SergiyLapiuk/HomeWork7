//Порушується принцип єдиного обов'язку
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        class Item
        {
        }
        class Order
        {
            private List<Item> itemList;
            internal List<Item> ItemList
            {
                get
                {
                    return itemList;
                }
                set
                {
                    itemList = value;
                }
            }
        }

        class OrderItems : Order
        {
            public void CalculateTotalSum() {/*...*/}
            public void GetItems() {/*...*/}
            public void GetItemCount() {/*...*/}
            public void AddItem(Item item) {/*...*/}
            public void DeleteItem(Item item) {/*...*/}
        }

        class OrderPrintShow : Order
        {
            public void PrintOrder() {/*...*/}
            public void ShowOrder() {/*...*/}
        }

        class ActionsWithTheOrder : Order
        {
            public void Load() {/*...*/}
            public void Save() {/*...*/}
            public void Update() {/*...*/}
            public void Delete() {/*...*/}
        }
        static void Main(string[] args)
        {
            
        }
    }
}
