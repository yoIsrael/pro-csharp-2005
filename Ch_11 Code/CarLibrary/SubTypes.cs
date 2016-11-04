using System;
using System.Windows.Forms;

namespace CarLibrary
{
	#region Sports car
	// The SportsCar
	public class SportsCar : Car
	{
		// Ctors.
		public SportsCar(){}
		public SportsCar(string name, short max, short curr)
			: base (name, max, curr){}

		// TurboBoost impl.
		public override void TurboBoost()
		{
			MessageBox.Show("Ramming speed!", "Faster is better...");
		}
	}
	#endregion 

	#region Minivan
	// The MiniVan
	public class MiniVan : Car
	{
		// Ctors.
		public MiniVan(){}
		public MiniVan(string name, short max, short curr)
			: base (name, max, curr){}

		// TurboBoost impl.
		public override void TurboBoost()
		{
			egnState = EngineState.engineDead;
			// The perfect API function ala .NET.
			MessageBox.Show("Time to call AAA", "Your car is dead");
		}

		public void TellChildToBeQuiet(string kidName, int numb)
		{
			for(int i = 0 ; i < numb; i++)
				MessageBox.Show("Be quiet " + kidName + "!!");
		}
	}
	#endregion
}
