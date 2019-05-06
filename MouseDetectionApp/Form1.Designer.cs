namespace MouseDetectionApp
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel = new System.Windows.Forms.Panel();
      this.eventLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // panel
      // 
      this.panel.Location = new System.Drawing.Point(12, 12);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(776, 406);
      this.panel.TabIndex = 0;
      this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onClick);
      this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
      this.panel.MouseEnter += new System.EventHandler(this.onMouseEnter);
      this.panel.MouseLeave += new System.EventHandler(this.onMouseLeave);
      this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
      this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
      // 
      // eventLabel
      // 
      this.eventLabel.AutoSize = true;
      this.eventLabel.Location = new System.Drawing.Point(21, 427);
      this.eventLabel.Name = "eventLabel";
      this.eventLabel.Size = new System.Drawing.Size(0, 13);
      this.eventLabel.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.eventLabel);
      this.Controls.Add(this.panel);
      this.Name = "Form1";
      this.Text = "Mouse Detection";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.Label eventLabel;
  }
}

