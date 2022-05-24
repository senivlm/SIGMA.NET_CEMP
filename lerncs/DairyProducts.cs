using System;

namespace lerncs
{
    public class DairyProducts : Product
	{
		public DateTime timeToExpire { get; private set; }

		public DairyProducts(DateTime date,
			string name, int price, double weight) : base(name, price, weight)
        {
			if (date == null)
				throw new ArgumentNullException();
			timeToExpire = date;
        }
		public override void ChangePrice(int percentage)
        {
			if(IsExpired())
            {
				percentage = percentage > 40 ? percentage - 30 : percentage;
            }
			Price = (int)((double)Price * (percentage / 100d));
		}
		public bool IsExpired()
        {
			return DateTime.Now > timeToExpire;
		}
	}
}

