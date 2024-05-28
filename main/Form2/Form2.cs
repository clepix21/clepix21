using System.Media;
using System.Windows.Forms;
using bounce.Properties;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        private SoundPlayer simpleSound;

        public Form2()
        {
            InitializeComponent();
            playSimpleSound();
        }

        private void playSimpleSound()
        {
            simpleSound = new SoundPlayer(Resources.bounce);
            simpleSound.PlayLooping();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopSimpleSound();
        }

        private void StopSimpleSound()
        {
            if (simpleSound != null)
            {
                simpleSound.Stop();
                simpleSound.Dispose();
            }
        }
    }
}