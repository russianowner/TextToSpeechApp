namespace TextToSpeechApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private TextBox txtInput;
        private Button btnSpeak;
        private Button btnStop;
        private Button btnClear;
        private ComboBox cmbVoices;
        private Label labelVoices;
        private TrackBar trackRate;
        private Label labelRate;
        private TrackBar trackVolume;
        private Label labelVolume;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new Label();
            this.txtInput = new TextBox();
            this.btnSpeak = new Button();
            this.btnStop = new Button();
            this.btnClear = new Button();
            this.cmbVoices = new ComboBox();
            this.labelVoices = new Label();
            this.trackRate = new TrackBar();
            this.labelRate = new Label();
            this.trackVolume = new TrackBar();
            this.labelVolume = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // labelTitle
            this.labelTitle.Text = "Text To Speech";
            this.labelTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.labelTitle.Location = new Point(20, 10);
            this.labelTitle.AutoSize = true;
            // txtInput
            this.txtInput.Multiline = true;
            this.txtInput.Size = new Size(450, 150);
            this.txtInput.Location = new Point(20, 55);
            this.txtInput.Font = new Font("Segoe UI", 11);
            // btnSpeak
            this.btnSpeak.Text = "Озвучить";
            this.btnSpeak.Font = new Font("Segoe UI", 10);
            this.btnSpeak.Size = new Size(120, 35);
            this.btnSpeak.Location = new Point(20, 330);
            this.btnSpeak.Click += new EventHandler(this.btnSpeak_Click);
            // btnStop
            this.btnStop.Text = "Стоп";
            this.btnStop.Font = new Font("Segoe UI", 10);
            this.btnStop.Size = new Size(120, 35);
            this.btnStop.Location = new Point(160, 330);
            this.btnStop.Click += new EventHandler(this.btnStop_Click);
            // btnClear
            this.btnClear.Text = "Очистить";
            this.btnClear.Font = new Font("Segoe UI", 10);
            this.btnClear.Size = new Size(120, 35);
            this.btnClear.Location = new Point(300, 330);
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // labelVoices
            this.labelVoices.Text = "Голос:";
            this.labelVoices.Font = new Font("Segoe UI", 10);
            this.labelVoices.Location = new Point(20, 215);
            this.labelVoices.AutoSize = true;
            // cmbVoices
            this.cmbVoices.Location = new Point(20, 240);
            this.cmbVoices.Size = new Size(250, 25);
            this.cmbVoices.DropDownStyle = ComboBoxStyle.DropDownList;
            // labelRate
            this.labelRate.Text = "Скорость:";
            this.labelRate.Font = new Font("Segoe UI", 10);
            this.labelRate.Location = new Point(300, 215);
            this.labelRate.AutoSize = true;
            // trackRate
            this.trackRate.Location = new Point(300, 240);
            this.trackRate.Minimum = -10;
            this.trackRate.Maximum = 10;
            this.trackRate.Value = 0;
            // labelVolume
            this.labelVolume.Text = "Громкость:";
            this.labelVolume.Font = new Font("Segoe UI", 10);
            this.labelVolume.Location = new Point(20, 280);
            this.labelVolume.AutoSize = true;
            // trackVolume
            this.trackVolume.Location = new Point(20, 305);
            this.trackVolume.Minimum = 0;
            this.trackVolume.Maximum = 100;
            this.trackVolume.Value = 100;
            // Form
            this.ClientSize = new Size(500, 400);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbVoices);
            this.Controls.Add(this.labelVoices);
            this.Controls.Add(this.trackRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.labelVolume);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Text To Speech";
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
