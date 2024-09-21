using System;

namespace Product{

    internal class DiningTable : CProduct{

        private float price;
        private string description;
        private float length;
        private int rating;
    

        public DiningTable ()
        {
            this.length = 5.4f;
            this.price = 55.5f;
            this.rating = 4;
            this.brand = "LG";
            this.id = 1;
            this.type = "Furniture";
            this.description = "Dinning Table";
            
        }

         public float Length{
            get {return length;}
            set {length = value;}
        }

        public float Price{
            get {return price;}
            set {price = value;}
        }

        public int Rating{
            get {return rating;}
            set {rating = value;}
        }

        public String Brand{
            get {return brand;}
            set {brand = value;}
        }

        public int Id{
            get {return id;}
            set {id = value;}
        }

        public String Type{
            get {return type;}
            set {type = value;}
        }
        
        public String Description{
            get {return description;}
            set {description = value;}
        }
        public override void Productdetail()
        {
            Console.WriteLine("Brand Name - " + brand);
            Console.WriteLine("Product Type - " + type);
            Console.WriteLine("Product Id - " + id);
            Console.WriteLine("Price - " + price);
            Console.WriteLine("Rating - " + rating);
            Console.WriteLine("Length - "+length);
            Console.WriteLine("Description -"+description);
        }
    }
}