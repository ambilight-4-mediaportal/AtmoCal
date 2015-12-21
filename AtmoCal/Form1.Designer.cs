namespace AtmoCal
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonExit = new System.Windows.Forms.Button();
      this.buttonRandom = new System.Windows.Forms.Button();
      this.textBoxRed = new System.Windows.Forms.TextBox();
      this.textBoxGreen = new System.Windows.Forms.TextBox();
      this.textBoxBlue = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.trackBarRed = new System.Windows.Forms.TrackBar();
      this.trackBarGreen = new System.Windows.Forms.TrackBar();
      this.trackBarBlue = new System.Windows.Forms.TrackBar();
      this.panel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
      this.panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonExit
      // 
      this.buttonExit.Location = new System.Drawing.Point(337, 162);
      this.buttonExit.Name = "buttonExit";
      this.buttonExit.Size = new System.Drawing.Size(75, 23);
      this.buttonExit.TabIndex = 0;
      this.buttonExit.Text = "Exit";
      this.buttonExit.UseVisualStyleBackColor = true;
      this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
      // 
      // buttonRandom
      // 
      this.buttonRandom.Location = new System.Drawing.Point(15, 162);
      this.buttonRandom.Name = "buttonRandom";
      this.buttonRandom.Size = new System.Drawing.Size(100, 23);
      this.buttonRandom.TabIndex = 2;
      this.buttonRandom.Text = "Random Color";
      this.buttonRandom.UseVisualStyleBackColor = true;
      this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
      // 
      // textBoxRed
      // 
      this.textBoxRed.Location = new System.Drawing.Point(362, 9);
      this.textBoxRed.Name = "textBoxRed";
      this.textBoxRed.ReadOnly = true;
      this.textBoxRed.Size = new System.Drawing.Size(50, 20);
      this.textBoxRed.TabIndex = 3;
      this.textBoxRed.Text = "128";
      // 
      // textBoxGreen
      // 
      this.textBoxGreen.Location = new System.Drawing.Point(362, 60);
      this.textBoxGreen.Name = "textBoxGreen";
      this.textBoxGreen.ReadOnly = true;
      this.textBoxGreen.Size = new System.Drawing.Size(50, 20);
      this.textBoxGreen.TabIndex = 4;
      this.textBoxGreen.Text = "128";
      // 
      // textBoxBlue
      // 
      this.textBoxBlue.Location = new System.Drawing.Point(362, 111);
      this.textBoxBlue.Name = "textBoxBlue";
      this.textBoxBlue.ReadOnly = true;
      this.textBoxBlue.Size = new System.Drawing.Size(50, 20);
      this.textBoxBlue.TabIndex = 5;
      this.textBoxBlue.Text = "128";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Red";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Green";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 114);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Blue";
      // 
      // trackBarRed
      // 
      this.trackBarRed.Location = new System.Drawing.Point(46, 9);
      this.trackBarRed.Maximum = 255;
      this.trackBarRed.Name = "trackBarRed";
      this.trackBarRed.Size = new System.Drawing.Size(310, 45);
      this.trackBarRed.TabIndex = 9;
      this.trackBarRed.Value = 128;
      // 
      // trackBarGreen
      // 
      this.trackBarGreen.Location = new System.Drawing.Point(46, 60);
      this.trackBarGreen.Maximum = 255;
      this.trackBarGreen.Name = "trackBarGreen";
      this.trackBarGreen.Size = new System.Drawing.Size(310, 45);
      this.trackBarGreen.TabIndex = 10;
      this.trackBarGreen.Value = 128;
      // 
      // trackBarBlue
      // 
      this.trackBarBlue.Location = new System.Drawing.Point(46, 111);
      this.trackBarBlue.Maximum = 255;
      this.trackBarBlue.Name = "trackBarBlue";
      this.trackBarBlue.Size = new System.Drawing.Size(310, 45);
      this.trackBarBlue.TabIndex = 11;
      this.trackBarBlue.Value = 128;
      // 
      // panel
      // 
      this.panel.Controls.Add(this.trackBarBlue);
      this.panel.Controls.Add(this.label1);
      this.panel.Controls.Add(this.trackBarGreen);
      this.panel.Controls.Add(this.buttonExit);
      this.panel.Controls.Add(this.trackBarRed);
      this.panel.Controls.Add(this.buttonRandom);
      this.panel.Controls.Add(this.label3);
      this.panel.Controls.Add(this.textBoxRed);
      this.panel.Controls.Add(this.label2);
      this.panel.Controls.Add(this.textBoxGreen);
      this.panel.Controls.Add(this.textBoxBlue);
      this.panel.Location = new System.Drawing.Point(429, 355);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(420, 200);
      this.panel.TabIndex = 12;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.panel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
      this.panel.ResumeLayout(false);
      this.panel.PerformLayout();
      this.ResumeLayout(false);

    }
    #endregion

    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Button buttonRandom;
    private System.Windows.Forms.TextBox textBoxRed;
    private System.Windows.Forms.TextBox textBoxGreen;
    private System.Windows.Forms.TextBox textBoxBlue;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar trackBarRed;
    private System.Windows.Forms.TrackBar trackBarGreen;
    private System.Windows.Forms.TrackBar trackBarBlue;
    private System.Windows.Forms.Panel panel;
  }
}

