using System;

namespace Product
{
    public abstract class CProduct : IProduct
    {
        protected String brand ;
        protected int id;
        protected String type;

        public CProduct( )
        {
          
        }

    public abstract void Productdetail();
      
        
    }
}