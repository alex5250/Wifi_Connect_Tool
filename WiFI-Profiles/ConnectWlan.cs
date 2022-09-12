using SimpleWifi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;

namespace WiFI_Profiles
{
    public class ConnectWlan
    {
        public String connect(String ssid, String passowrd)
        {
            // Wifi object
            Wifi wifi = new Wifi();
            StringBuilder main = new StringBuilder();

            // get list of access points
            IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints();

            // for each access point from list
            foreach (AccessPoint ap in accessPoints)
            { 

                main.AppendFormat("ap: {0}\r\n", ap.Name);

                //check if SSID is desired
                if (ap.Name.StartsWith(ssid))
                {
                    //verify connection to desired SSID

                    main.AppendFormat("connected: {0}, password needed: {1}, has profile: {2}\r\n", ap.Name, ap.IsConnected, ap.HasProfile);
                    if (!ap.IsConnected)
                    {
                        //connect if not connected
                        main.AppendFormat("\r\n{0}\r\n", ap.ToString());
                        main.AppendFormat("Trying to connect..\r\n");
                        AuthRequest authRequest = new AuthRequest(ap);
                        authRequest.Password = passowrd;
                        ap.Connect(authRequest);
                    }
                }
            }

            return main.ToString();



        }
    }
}
