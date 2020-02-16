using System;

namespace OCP
{
    public class Product
    {
        private ILogger logger;

        public Product(ILogger logger)
        {
            this.logger = logger;
        }

        public void SetPriceOfProduct(double price)
        {
            try
            {
                //to save a price value to DB 
                Console.WriteLine("trying to set new value of price....."+price);
                throw new Exception("some simulation exception...");
            }
            catch (Exception ex)
            {
                logger.SaveLog(ex.Message);
            }
        }
    }
}
