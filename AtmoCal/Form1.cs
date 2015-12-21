using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmoCal
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      panel.Location = new Point((Screen.FromControl(this).WorkingArea.Width - panel.Width) / 2, (Screen.FromControl(this).WorkingArea.Height - panel.Height) / 2);
      trackBarRed.ValueChanged += trackBarRed_ValueChanged;
      trackBarGreen.ValueChanged += trackBarGreen_ValueChanged;
      trackBarBlue.ValueChanged += trackBarBlue_ValueChanged;
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void buttonRandom_Click(object sender, EventArgs e)
    {
      Random r = new Random();
      trackBarRed.Value = r.Next(0, 255);
      trackBarGreen.Value = r.Next(0, 255);
      trackBarBlue.Value = r.Next(0, 255);
      textBoxRed.Text = trackBarRed.Value.ToString();
      textBoxGreen.Text = trackBarGreen.Value.ToString();
      textBoxBlue.Text = trackBarBlue.Value.ToString();
      this.BackColor = Color.FromArgb(Int32.Parse(textBoxRed.Text), Int32.Parse(textBoxGreen.Text), Int32.Parse(textBoxBlue.Text));
    }

    private void trackBarRed_ValueChanged(object sender, EventArgs e)
    {
      textBoxRed.Text = trackBarRed.Value.ToString();
      this.BackColor = Color.FromArgb(Int32.Parse(textBoxRed.Text), Int32.Parse(textBoxGreen.Text), Int32.Parse(textBoxBlue.Text));
    }

    private void trackBarGreen_ValueChanged(object sender, EventArgs e)
    {
      textBoxGreen.Text = trackBarGreen.Value.ToString();
      this.BackColor = Color.FromArgb(Int32.Parse(textBoxRed.Text), Int32.Parse(textBoxGreen.Text), Int32.Parse(textBoxBlue.Text));
    }

    private void trackBarBlue_ValueChanged(object sender, EventArgs e)
    {
      textBoxBlue.Text = trackBarBlue.Value.ToString();
      this.BackColor = Color.FromArgb(Int32.Parse(textBoxRed.Text), Int32.Parse(textBoxGreen.Text), Int32.Parse(textBoxBlue.Text));
    }
  }
}
