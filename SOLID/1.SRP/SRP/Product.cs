﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class Product
    {
        private Logger logger;

        public Product(Logger logger)
        {
            this.logger = logger;
        }

        public void SetPrice(double price)
        {
            try
            {
                //to save a price value to DB 
                Console.WriteLine("trying to set new value of price.....");
                throw new Exception("some simulation exception...");
            }
            catch (Exception ex)
            {
                logger.SaveLog(ex.Message);
            }
        }
    }
}
