using Plugin.BluetoothLE;
using System;
namespace bluetoothScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            CrossBleAdapter.Current.Scan().Subscribe(scanResult => {
                Console.WriteLine(scanResult.AdvertisementData.LocalName);
            });
        }
    }
}
