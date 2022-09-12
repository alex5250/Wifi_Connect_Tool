using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WiFI_Profiles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
            

        }
       
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            ProfileLoad profileLoad = new ProfileLoad();
            ComboBox comboBox = this.Find<ComboBox>("Select");
            var data=profileLoad.GetWiFIProfiles();
            List<SSID> ssid = new List<SSID>(); 
            foreach (var item in data) {
                ssid.Add(new SSID(item.ssid,item.password));
            }
            comboBox.Items = ssid;
            comboBox.SelectedIndex = 0;
        
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = this.Find<ComboBox>("Select");
            TextBox textBox = this.Find<TextBox>("textbox");
            WiFI_Profiles.SSID id= (SSID)comboBox.SelectedItem;

            textBox.Text = "Selected profile:" + id.Name;
            ConnectWlan connect = new ConnectWlan();
            var text=connect.connect(id.Name, id.NoteText);
            textBox.Text = text;

        }
       
    }

}
