using System;

namespace Task_2._1
{
    public class Product
	{
        //public string Name { get; }
        private string name;
        private int price;
		public int Price { 
			get 
			{
				return price;
			}
			set {
				if (price < 0)
					throw new ArgumentException();
				price = value;
			}
		}
		private double weight;
		public double Weight { get; set; }
        public string Name { get => name; set => name = value; }

		public Product() : this("nan", 0, 0)
		{
			
		}

		public Product(string name, int price, double weight)
		{
			if (price < 0 || weight < 0)
				throw new ArgumentException();
			Name = name;
			Price = price;
			Weight = weight;
		}

		public virtual void ChangePrice(int percentage)
        {
			Price = (int)(Price * (percentage / 100d));
		}

        public override string ToString()
        {
            return string.Format("name: {0}, price: {1}, weight: {2}", name, price, Weight);
        }
		
		public void Parse(string str)
        {
			if(str == null)
            {
				throw new ArgumentNullException();
            }
			string[] arrayString = str.Split(' ');
			Name = arrayString[0];
			Price = Convert.ToInt32(arrayString[1]);
			if (!double.TryParse(arrayString[2], out weight))
            {
				throw new ArgumentException();
            }
            
        }
	}
}

