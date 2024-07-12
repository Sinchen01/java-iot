using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.IO.Ports;

namespace GeoAutoRunner
{

    class DeviceManager
    {
        public static string GetConnectedPort()
        {
            string port = null;
            using (var searcher = new ManagementObjectSearcher
              ("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();


                foreach (string s in tList)
                {
                    if (s.ToLower().IndexOf("arduino") != -1)
                    {
                        port = s.Split('-')[0].Trim();
                        break;
                    }
                }
            }

            return port;
        }
    }
}
