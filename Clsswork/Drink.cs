using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Clsswork
{
    class Drink : IComparable, IComparable<Drink>, IEquatable<Drink>
    {
        public enum DrinkTypes
        {
            Water = 1, Carbonated, NonCarbonated, HotDrink, Alcoholic
        }
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Producer
        {
            get; set;
        }
        public ushort Kkal
        {
            get; set;
        }
        public uint Price
        {
            get; set;
        }
        private DrinkTypes drinktype=0;
        public Drink(string name,DrinkTypes drink_type, string producer , ushort kkal,uint price)
        {
            Name = name;
            Producer = producer;
            Kkal = kkal;
            this.drinktype = drink_type;
            Price = price;
        }
        public override string ToString()
        {
            return $"Drink\nType:{drinktype}, Name: {name}, Producer: {Producer}, KKal: {Kkal}, Price: {Price}"; 
        }

        public int CompareTo(object obj)
        {

            if (!(obj is Drink))
            {
                throw new FormatException("Bad Compare Type, (Ooj isn`t Drink)");
            }
            Drink nd = (obj as Drink);
            if (this.drinktype != nd.drinktype)
            {
                return this.drinktype.CompareTo(nd.drinktype);
            }
            return this.name.CompareTo(nd.name);
        }

        public int CompareTo([AllowNull] Drink other)
        {
            if (this.drinktype != other.drinktype)
            {
                return this.drinktype.CompareTo(other.drinktype);
            }
            return this.name.CompareTo(other.name);
        }

        public bool Equals([AllowNull] Drink other)
        {
            return this.Producer == other.Producer && this.Name == other.Name && this.Kkal == other.Kkal && this.Price == other.Price && this.drinktype == other.drinktype;
        }
    }
    class CompareDrinkprice : IComparer<Drink>
    {
        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return x.Price.CompareTo(y.Price);
        }

     class CompareDrinkKals : IComparer<Drink>
        {
            public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
            {
                return x.Kkal.CompareTo(y.Kkal);
            }
        }
    class CompareDrinkProducer
        {
            public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
            {
                return x.Producer.CompareTo(y.Producer);
            }
        }
    }
    class CompareDesPrice : IComparer
    {
        public int Compare(object x, object y)
        {

            if (x is Drink && y is Drink)
            {
                Drink one = x as Drink;
                Drink two = y as Drink;
                return -one.Price.CompareTo(two.Price);
            }
            else{
                throw new Exception("Bad type");
            }
        }
    }
    class CompareKallDrink : IComparer
    {
        public int Compare(object x, object y)
        {

            if (x is Drink && y is Drink)
            {
                Drink one = x as Drink;
                Drink two = y as Drink;
                return one.Kkal.CompareTo(two.Kkal);
            }
            else
            {
                throw new Exception("Bad type");
            }
        }
    }
    class CompareProducerDrink : IComparer
    {
        public int Compare(object x, object y)
        {

            if (x is Drink && y is Drink)
            {
                Drink one = x as Drink;
                Drink two = y as Drink;
                return one.Producer.CompareTo(two.Producer);
            }
            else
            {
                throw new Exception("Bad type");
            }
        }
    }
}
