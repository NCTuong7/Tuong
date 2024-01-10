using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;
using NAudio.Wave;

namespace To_Chi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			//waveOutDevice = new WaveOut();
			Text = "Happy Birthday To Chi";
            Name = "Fireworks";
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            ClientSize = new Size(841, 751);
            Timer timer = new Timer();
            timer.Tick += new EventHandler(Tick);
            timer.Interval = UpdateInterval;
            timer.Start();
        }
		const int MaxFireWorks = 10;

		Firework[] fireworks = new Firework[MaxFireWorks];

		static Random rand = new Random();

		void Tick(Object o, EventArgs e)
		{

			for (int i = 0; i < MaxFireWorks; ++i)
				if (fireworks[i] != null)
					if (!fireworks[i].Update())
						fireworks[i] = null;

			if (rand.Next(10) == 0)
				for (int i = 0; i < MaxFireWorks; ++i)
					if (fireworks[i] == null)
					{
						fireworks[i] = new Firework(ClientRectangle.Width,
									ClientRectangle.Height);
						break;
					}

			Invalidate();

			Update();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.Clear(Color.Black);
			foreach (Firework fw in fireworks)
				if (fw != null)
					fw.Paint(e.Graphics);
		}

		const int UpdateInterval = 1;

        //private SoundPlayer soundPlayer;
        //private IWavePlayer waveOutDevice;
        //private AudioFileReader audioFileReader;
        private void Form1_Load(object sender, EventArgs e)
        {
            //	string resourceName = "To_Chi.Resources.ChucMungSinhNhat-HoaTau-3089002.mp3";




            //	Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            //	byte[] byteArray;
            //	using (MemoryStream memoryStream = new MemoryStream())
            //	{
            //		stream.CopyTo(memoryStream);
            //		byteArray = memoryStream.ToArray();
            //	}

            //	string resultString = Convert.ToBase64String(byteArray);
            //          audioFileReader = new AudioFileReader(resultString);


            //	waveOutDevice.Init(audioFileReader);
            //	waveOutDevice.Play();
        }
    }
}
