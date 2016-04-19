using System;
using XamarinDFU;
using System.Collections.Generic;

namespace XamarinDFU
{
	public class DFUService
	{
		public event EventHandler<ServiceEventArgs> writeToPeripheral = delegate {};
		public List<String> registeredUUIDs;
			
		public DFUService ()
		{
			registeredUUIDs = new List<String> ();
			registeredUUIDs.Add ("2a19");
		}

		public void peripheralUpdatedCharacteristicValueCallback(string UUID, byte [] packet)
		{
			// TBD...
		}

		// Send a new value to the peripheral
		void updatePeripheralCharacteristic()
		{
			byte[] newCharValues = new byte[16];
			string UUID = "2a19";
			writeToPeripheral(this, new ServiceEventArgs(UUID,newCharValues));
		}
	}

}