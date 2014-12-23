using System;

namespace Lab3
{
	public static class PricingTable
	{
		public static float getPrice(int tariefeenheden, int col)
		{
			switch (col) {
			case 0:
				return 2.10f;
			case 1:
				return 1.70f;
			case 2:
				return 1.30f;
			case 3:
				return 3.60f;
			case 4:
				return 2.90f;
			case 5:
				return 2.20f;
			default:
				throw new Exception ("Unknown column number");
			}
		}
	}
}

