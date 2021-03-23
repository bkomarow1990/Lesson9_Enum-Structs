using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork
{
    class Client
    {
        int code;
        string PIB;
        string adress;
        string phone;
        int count_orders;
        double summ;
        public int Code
        {
            get => code;
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get => PIB;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Incorrect name");
                }
                this.PIB = value;
            }
        }
        public string Adress
        {
            get => adress;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Incorrect name");
                }
                this.adress = value;
            }
        }
        public string Phone
        {
            get => phone;
            set
            {
                string tmp = value.Remove(0, 1);// (string)value;
                if (tmp.All(c => char.IsDigit(c)) && value[0] == '+')
                {
                    this.phone = value;
                }
                else
                {
                    Console.WriteLine("Number of client isn`t correct");
                }
            }
        }
        public int CountOrders
        {
            get => count_orders;
            set
            {
                if (value < 0)
                {
                    throw new Exception("To few orders");
                }
                this.count_orders = value;
            }
        }
        public double SummOrders
        {
            get => summ;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative Summ");
                }
                this.summ = value;
            }
        }
        public Client(int code,string PIB,string adress, string phone, int count_orders)
        {
            this.Code = code;
            this.Name = PIB;
            this.Adress = adress;
            this.Phone = phone;
            this.CountOrders = count_orders;
        }
        public override string ToString()
        {
            return $"Client:\nCode: {code}, PIB: {PIB}\nAdress: {adress}, Count Orders: {count_orders}, SummOrders: {SummOrders}, Phone: {phone}";
        }
    }
}
