using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpeechControl
{
    public partial class SpeechControl: UserControl
    {
        public SpeechSynthesizer synthesizer;
        public string textToSpeech;
        public string whois;
        public VoiceInfo voiceInfo;
        public bool comboYes = false;

        public SpeechControl()
        {
            InitializeComponent();
            CreateSynthesizer();
            BuildListVoice();
            this.pause.Enabled = false;
            this.resume.Enabled = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            synthesizer.Dispose();
            this.trackBar1.Value = 0;
            this.pause.Enabled = false;
            this.resume.Enabled = false;
            label1.Text = "Stopped";
        }

        private void speech_Click(object sender, EventArgs e)
        {
            if (textToSpeech != "")
            {
                stop_Click(null, null);
                CreateSynthesizer();
                resume_Click(null, null);
                synthesizer.SpeakAsync(textToSpeech);
                this.trackBar1.Maximum = textToSpeech.Length;
            }
            else { MessageBox.Show("lol"); }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.Pause();
                this.pause.Enabled = false;
                this.resume.Enabled = true;
                label1.Text = "Paused";
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
            {
                synthesizer.Resume();
                this.pause.Enabled = true;
                this.resume.Enabled = false;
                label1.Text = "Speaking";
            }
        }

        public void textToSpeechFinished(object sender, SpeakCompletedEventArgs e)
        {
            stop_Click(null, null);
        }
        public void textToSpeechProgress(object sender, SpeakProgressEventArgs e)
        {
            this.trackBar1.Value = e.CharacterPosition;
        }

        [Category("SpeechControl"),Description("The color of backk the whole SpeechControl")]
        public Color SpeechControl_BackColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; this.voice.BackColor = this.BackColor; }
        }

        private void voice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (synthesizer.State != SynthesizerState.Speaking)
                {
                    comboYes = true;
                    label1.Text = "";
                    CreateSynthesizer();
                }
            }
            catch { }

        }

        private void CreateSynthesizer()
        {
            synthesizer = new SpeechSynthesizer();
            if (comboYes)
            {
                string voicestring = "";
                
                voicestring = this.voice.SelectedItem.ToString();
                synthesizer.SelectVoice(voicestring);
            }

            synthesizer.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(textToSpeechFinished);
            synthesizer.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(textToSpeechProgress);

        }

        private void BuildListVoice() 
        {
            System.Collections.ObjectModel.ReadOnlyCollection<InstalledVoice> GlosyWGlowie = synthesizer.GetInstalledVoices();
            List<string> ListaGlosow = new List<string>();
            foreach(InstalledVoice x in GlosyWGlowie)
            {
                ListaGlosow.Add(x.VoiceInfo.Name);
            }
            this.voice.DataSource = ListaGlosow;
        }
    }
}
