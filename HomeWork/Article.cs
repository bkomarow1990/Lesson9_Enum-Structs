using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HomeWork
{
    struct ComparerArticleByCode : IComparer<Article> // вирішив зробити по code, бо по price вже було пару раз
    {
        public int Compare([AllowNull] Article x, [AllowNull] Article y)
        {
           
            return x.Code.CompareTo(y.Code);
        }
    }
    struct Article : IComparable
    {
        public enum Category
        {
            Household =1,Gadgets,Machinery,Products
        }
        int code;
        public int Code { get => code; }
        string name;
        public double Price { get; set; }
        Category category;
        public Article(int code , string name, double price ,Category category)
        {
            this.code = code;
            this.name = name;
            this.Price = price;
            this.category = category;
        }
        public override string ToString()
        {
            return $"Article:\nCategory{category}, Price: {Price}, Code: {code}, Name: {name}"; 
        }
        public static int SortArticleByPrice(Article one, Article two)
        {
            return one.Price.CompareTo(two.Price);
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Article))
            {
                throw new Exception("Object isn`t Article");
            }
            Article tmp = (Article)obj;
            return Price.CompareTo(tmp.Price);
        }
    }
}
