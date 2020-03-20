using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace FelisTTS
{
    public partial class DeviceList : Form
    {
        public Action<int> callback;
        public DeviceList()
        {
            InitializeComponent();
        }

        private void DeviceList_Load(object sender, EventArgs e)
        {
            for (int i = -1; i < WaveOut.DeviceCount; i++)
            {
                var boxItem = new DeviceBoxItem(WaveOut.GetCapabilities(i),i);
                this.deviceListBox.Items.Add(boxItem);
                
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DeviceBoxItem item = this.deviceListBox.SelectedItem as DeviceBoxItem;
            this.callback(item.devNum);
            this.Close();
        }
    }

    public class DeviceBoxItem
    {
        WaveOutCapabilities caps;
        public int devNum = 0;

        public DeviceBoxItem(WaveOutCapabilities c, int num)
        {
            caps = c;
            devNum = num;
        }

        public override string ToString()
        {
            return caps.ProductName;
        }

    }
}
