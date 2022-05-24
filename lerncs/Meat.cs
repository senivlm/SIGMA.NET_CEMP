using System;

namespace lerncs
{
    public class Meat : Product
	{
		public Category MeatCategory { get; }
		public Species MeatSpecies { get; }

		public Meat():this(default, default,default,default,default)
        {

        }
		public Meat(Category meatCategory, Species meatSpecies, string name, int price, double weight) : base( name, price, weight)
        {
			MeatCategory = meatCategory;
			MeatSpecies = meatSpecies;
        }
		public override void ChangePrice(int percentage)
		{
            switch (MeatCategory)
            {
				case Category.HighSort:
					percentage += 25;
					break;
				case Category.Sort1:
					percentage += 15;
					break;
				case Category.Sort2:
					percentage += 10;
					break;
				default:
					break;
            }
			//if (IsExpired())
			//{
			//	percentage = percentage > 40 ? percentage - 30 : percentage;
			//}
			//Price = (int)((double)Price * (percentage / 100d));
		}

        public override string ToString()
        {
            return base.ToString() + $" MeatCategory: {MeatCategory}, MeatSpesies: {MeatSpecies}";
        }

		public void trash()
        {
			Console.WriteLine("I`m trash");
        }
    }

}

