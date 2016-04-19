using System;

namespace dfu.shared
{
	public class ServiceEventArgs : EventArgs 
	{
		public  byte [] m_byteArray;
		public string m_UUID;
		public bool requestResponse;
		public ServiceEventArgs(string _UUID, byte [] _myData, bool _requestResponse = false)
		{
			m_byteArray = _myData;
			m_UUID = _UUID;
			requestResponse = _requestResponse;
		}
	}
}

