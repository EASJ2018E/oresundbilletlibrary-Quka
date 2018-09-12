using System;

namespace OresundBilletLibrary
{
	public class Bil : BilletLibrary.Bil
	{
		/// <summary>
		/// Returns the price of admission for Øresundsbrosen for Car
		/// 420 is standard price, 161 is price with brobizz
		/// </summary>
		/// <returns>int 420 or 161 if brobizz is used</returns>
		public override decimal Pris()
		{
			return Brobizz ? 161 : 420;
		}

		/// <summary>
		/// Returns the type (køretøj)  of this vehicle 
		/// </summary>
		/// <returns>Returns the vehicle type (køretøj)</returns>
		public override string Type()
		{
			return "Øresund Bil";
		}
	}
}
