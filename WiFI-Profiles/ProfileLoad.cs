using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static WiFI_Profiles.WifiJson;
using System.Xml;
namespace WiFI_Profiles
{
    public class ProfileLoad

    {
        public  WifiProfile[] GetWiFIProfiles()
        {

            List<WifiProfile> wifiProfiles = new List<WifiProfile>();
            var data=File.ReadAllLines("WifiProfiles.txt");
            foreach (string a in data)
            {

                
                if(a.Split(';').Length> 1) { 
                wifiProfiles.Add(new WifiProfile(a.Split(';')[0], a.Split(';')[1]));
                }


            }
            return wifiProfiles.ToArray();
        }
    }
}











