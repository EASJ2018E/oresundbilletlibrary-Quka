using System;
using System.Collections.Generic;
using System.Text;

namespace OresundBilletLibrary
{
	public class MC : BilletLibrary.MC
	{
		/// <summary>
		/// Returns the price of admission for Øresundsbrosen for MC
		/// 210 is standard price, 73 is price with brobizz
		/// </summary>
		/// <returns>int 210 or 73 if brobizz is used</returns>
		public override decimal Pris()
		{
			return Brobizz ? 73 : 210;
		}

		/// <summary>
		/// Returns the type (køretøj)  of this vehicle
		/// </summary>
		/// <returns>Returns the vehicle type (køretøj)</returns>
		public override string Type()
		{
			return "Øresund MC";
		}
	}
}
