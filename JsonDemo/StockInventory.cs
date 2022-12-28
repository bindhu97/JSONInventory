﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    public class StockInventory
    {
        Model Stocks = new Model();
        List<Model> Stockslist = new List<Model>();

        public void convert(string jFilePath)
        {

            using (StreamReader reader = new StreamReader(jFilePath))
            {
                double totalStock = 0;
                var json = reader.ReadToEnd();
                var shares = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Stock account Management");

                foreach (var share in shares)
                {
                    double value = share.StockPrice * share.NumberOfShares;

                    Console.WriteLine(share.Company + " " + share.NumberOfShares + " " + share.StockPrice + " " + value);

                    totalStock += value;
                }
                Console.WriteLine("Toatal value of All Stocks is : " + totalStock);
            }
        }
    }
}