#nullable disable
using System.Speech.Synthesis;

namespace TextToSpeechApp
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            LoadVoices();
        }
        private void LoadVoices()
        {
            var voices = synth.GetInstalledVoices().Select(v => v.VoiceInfo.Name);
            foreach (var voice in voices)
                cmbVoices.Items.Add(voice);
            if (cmbVoices.Items.Count > 0)
                cmbVoices.SelectedIndex = 0;
        }
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("¬веди текст!");
                return;
            }
            synth.SelectVoice(cmbVoices.SelectedItem.ToString());
            synth.Rate = trackRate.Value;
            synth.Volume = trackVolume.Value;
            synth.SpeakAsync(txtInput.Text);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
