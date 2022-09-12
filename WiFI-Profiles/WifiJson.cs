using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFI_Profiles
{
    public class WifiJson
    {

        public class Rootobject
        {
            public WifiProfile Property1 { get; set; }
        }

        public class WifiProfile
        {
            public WifiProfile(string? ssid, string? password)
            {
                this.ssid = ssid;
                this.password = password;
            }

            public string ssid { get; set; }
            public string password { get; set; }
        }

    }
}
