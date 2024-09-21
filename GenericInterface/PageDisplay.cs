using System;

namespace Product
{
    public class PageDisplay <T> where T : IProduct ,new ()
    {
        T product;
        
        public PageDisplay()
        {
            product = new T();
            product.Productdetail();
        }
    }

}