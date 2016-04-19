# XamarinDFU
C# implementation of FOTA DFU

This repository holds code that will implement the Device Firmware Update (a.k.a Firmware Over The Air) using Xamarin C#.
The base class DFUService is OS agnostic. To implement this for a specific OS, small functions will need to be implemented to communicate with the BLE stack.
