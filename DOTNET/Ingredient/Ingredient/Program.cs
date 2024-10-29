using System;

namespace Ingredient
{
    interface IPrice
    {
        public double CalculatePrice(int quantity);
    }
    class Ingredient
    {
        private const double _sodaPrice = 15;
        private readonly int _sodaQuantity;
        private readonly int _alchoholQuantity;

        public Ingredient(int sodaQuantity, int alchoholQuantity)
        {
            _sodaQuantity = sodaQuantity;
            _alchoholQuantity = alchoholQuantity;
        }

        public double IngredientsAmount()
        {
            return (_sodaQuantity * _sodaPrice) + (_alchoholQuantity * _sodaPrice);
        }
    }
    class BlueOcean : IPrice
    {
        private const int _sodaQuantity = 2;
        private const int _alchoholQuantity = 2;

        public double CalculatePrice(int quantity)
        {
            Ingredient ingredient = new Ingredient(_sodaQuantity, _alchoholQuantity);
            double ingredientAmount = ingredient.IngredientsAmount();
            return ingredientAmount * quantity;
        }
    }
    class Mojito : IPrice
    {
        private int _sodaQuantity = 4;
        private const int _alchoholQuantity = 2;

        public double CalculatePrice(int quantity)
        {
            Ingredient ingredient = new Ingredient(_sodaQuantity, _alchoholQuantity);
            double ingredientAmount = ingredient.IngredientsAmount();
            return ingredientAmount * quantity;
        }
    }
    class PrepareBill
    {
        public double CalculateDrinkPrice(Func<int, double> CalculatePrice, int quantity)
        {
            return CalculatePrice(quantity);
        }
    }
    class Program
    {
        static void Main()
        {
            Func<int, double> calculatePrice = new BlueOcean().CalculatePrice;
            var amount = new PrepareBill().CalculateDrinkPrice(calculatePrice, 10);
            Console.WriteLine($"BlueOcean Price: {amount}");
            calculatePrice = new Mojito().CalculatePrice;
            amount = new PrepareBill().CalculateDrinkPrice(calculatePrice, 5);
            Console.WriteLine($"Mojito Price: {amount}");
        }
    }
}

