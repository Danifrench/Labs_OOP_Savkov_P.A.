using System;

namespace OOP_LAB_6
{
	class Good
	{
		public static int count;

		public Good() { }
		public Good(float cost, string name)
		{
			_cost = cost;
			_name = name;
			count++;
			_id = count + 100;
		}

		public int GetID()
        {
			return _id;
        }

		public float GetCost()
        {
			return _cost;
        }

		private float _cost;
		private int _id;
		private string _name;
	}
}
