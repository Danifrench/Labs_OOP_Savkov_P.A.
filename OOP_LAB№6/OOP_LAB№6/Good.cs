using System;

namespace OOP_LAB_6
{
	class Good
	{
		public Good(float cost, string name)
		{
			_cost = cost;
			_name = name;
			_id = CreateID();
		}

		static int CreateID()
        {
			Random rnd = new Random();
			return rnd.Next(100, 999);
		}
		private float _cost;
		private int _id;
		private string _name;
	}
}
