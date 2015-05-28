using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsReadGhana
{
    public partial class frmSplashScreen : Form
    {
        private Timer _timer; // create timer object

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            this._timer = new Timer(); // instanciate timer object 
            this._timer.Interval = 2000; // set 2seconds of interval per tick
            this._timer.Start(); // start timers
            this._timer.Tick += _timer_Tick; //subscibe timer object to the tick event
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            this._timer.Stop(); // stop timers object
            frmMain formMain = new frmMain(); // create and instanciate main form object
            formMain.Show(); //show form in the GUI
            this.Hide(); // hide splash screen form 
        }
    }
}
