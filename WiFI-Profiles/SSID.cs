namespace WiFI_Profiles
{
    public class SSID
    {
        public string Name { get; set; }
        public string NoteText { get; set; }


        public SSID(string ssid,string password)
        {
            this.Name = ssid;
            this.NoteText = password;
        }
    }
}