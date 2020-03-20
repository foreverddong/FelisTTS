using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Threading;

namespace FelisTTS
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer syn;
        public int deviceNumber = 0;
        AudioFileReader reader = null;
        WaveOutEvent outDevice = null;
        public Form1()
        {
            syn = new SpeechSynthesizer();
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var voice in syn.GetInstalledVoices())
            {
                this.voicesBox.Items.Add(new VoiceWrapper() {voice = voice });
            }
        }

        private void TTSButton_Click(object sender, EventArgs e)
        {
            outDevice = new WaveOutEvent(){ DeviceNumber = this.deviceNumber };
            outDevice.PlaybackStopped += OutDevicePlayStopped;
            syn.SetOutputToWaveFile("generatedvoice.wav");
            syn.Speak(this.voiceTextBox.Text);
            syn.SetOutputToNull();
            reader = new AudioFileReader("generatedvoice.wav");
            outDevice.Init(reader);
            outDevice.Play();
            syn.SetOutputToDefaultAudioDevice();
            syn.SpeakAsync(this.voiceTextBox.Text);
            //syn.SetOutputToDefaultAudioDevice();
            //syn.Speak(this.voiceTextBox.Text);
            //stream.Position = 0;
            


        }

        private void OutDevicePlayStopped(object sender, StoppedEventArgs e)
        {
            reader.Dispose();
            outDevice.Dispose();
        }

        private void deviceButton_Click(object sender, EventArgs e)
        {
            var devForm = new DeviceList();
            devForm.callback = (devNum) => this.deviceNumber = devNum;
            devForm.Show();
        }

        private void voicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoiceWrapper voice = this.voicesBox.SelectedItem as VoiceWrapper;
            this.syn.SelectVoice(voice.voice.VoiceInfo.Name);
        }
    }

    public class VoiceWrapper
    {
        public InstalledVoice voice;
        public override string ToString()
        {
            return voice.VoiceInfo.Name;
        }
    }
}
