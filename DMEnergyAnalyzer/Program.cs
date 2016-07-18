using System;
using System.Management;
using System.Windows.Forms;

namespace WMISample
{
    public class MyWMIQuery
    {
        public static void Main()
        {
            try
            {
                ManagementObjectSearcher searcher =
                     new ManagementObjectSearcher("root\\WMI",
                     "SELECT * FROM MSWmi_ProviderInfo");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("MSWmi_ProviderInfo instance");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Active: {0}", queryObj["Active"]);
                    Console.WriteLine("Description: {0}", queryObj["Description"]);
                    Console.WriteLine("FriendlyName: {0}", queryObj["FriendlyName"]);
                    Console.WriteLine("InstanceName: {0}", queryObj["InstanceName"]);
                    Console.WriteLine("Location: {0}", queryObj["Location"]);
                    Console.WriteLine("Manufacturer: {0}", queryObj["Manufacturer"]);
                    Console.WriteLine("Service: {0}", queryObj["Service"]);
                }








                Console.ReadLine();
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
        }
    }
}