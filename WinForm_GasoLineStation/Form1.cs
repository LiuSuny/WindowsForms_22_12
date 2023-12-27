using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinForm_GasoLineStation
{
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
        }
       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb( 0,3, 7, 255);
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            


        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb( 0,3, 7, 255);
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb( 0,3, 7, 255);
            panel1.BackColor = Color.FromArgb(trackBar3.Value, trackBar2.Value, trackBar1.Value);
        }

        private void RusLanguage_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("russian");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("russian");
           
            System.ComponentModel.ComponentResourceManager resource =
                new System.ComponentModel.ComponentResourceManager(this.GetType());
            resource.ApplyResources(this, $"this");
            foreach (Control c in this.Controls)
                resource.ApplyResources(c, c.Name);
        }

        private void EnglishLang_Click(object sender, EventArgs e)
        {
        
           
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
           
            System.ComponentModel.ComponentResourceManager resource =
                new System.ComponentModel.ComponentResourceManager(this.GetType());
            resource.ApplyResources(this, $"this");
            foreach (Control c in this.Controls)
                resource.ApplyResources(c, c.Name);
        }

        private void FrenchToolLang_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");

            System.ComponentModel.ComponentResourceManager resource =
                new System.ComponentModel.ComponentResourceManager(this.GetType());
            resource.ApplyResources(this, $"this");
            foreach (Control c in this.Controls)
                resource.ApplyResources(c, c.Name);
        }
    }
}
