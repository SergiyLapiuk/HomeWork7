/* Даний інтерфейс поганий тим, що він включає занадто багато
методів. Що, якщо наш клас товарів не може мати знижок або
промокодом, або для нього немає сенсу встановлювати матеріал з якого
зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в
кожному класі невикористовувані в ньому методи, краще розбити
інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати
потрібні інтерфейси.*/
// Порушується принцип розділення інтерфейсу
using System;

namespace ConsoleApp1
{
    interface IApplyDiscount
    {
        void ApplyDiscount(String discount);
    }

    interface IApplyPromocode
    {
        void ApplyPromocode(String promocode);
    }
    interface ISetColor
    {
        void SetColor(byte color);
    }
    interface ISetSize
    {
        void SetSize(byte size);
    }

    interface ISetPrice
    {
        void SetPrice(double price);
    }

    class Book: IApplyDiscount, IApplyPromocode, ISetPrice
    {
        void IApplyPromocode.ApplyPromocode(String promocode) { }
        void IApplyDiscount.ApplyDiscount(String discount) { }
        void ISetPrice.SetPrice(double price) { }
    }

    class Outerwear: IApplyDiscount, IApplyPromocode, ISetPrice, ISetSize, ISetColor
    {
        void IApplyPromocode.ApplyPromocode(String promocode) { }
        void IApplyDiscount.ApplyDiscount(String discount) { }
        void ISetPrice.SetPrice(double price) { }
        void ISetSize.SetSize(byte size) { }
        void ISetColor.SetColor(byte color) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
