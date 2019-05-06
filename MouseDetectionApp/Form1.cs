using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDetectionApp
{
  public partial class Form1 : Form
  {
    private Point mousePosition = new Point(0, 0);
    private bool dragging = false;
    private bool mouseDown = false;
    public Form1()
    {
      InitializeComponent();
      panel.BackColor = Color.White;
      eventLabel.Text = "Mouse outside panel";
    }

    private void onClick(object sender, MouseEventArgs e)
    {

    }

    private void onMouseDown(object sender, MouseEventArgs e)
    {
      if ((Panel)sender == panel)
      {
        mouseDown = true;
        eventLabel.Text = $"Pressed at [{e.X}, {e.Y}]";
      }
    }

    private void onMouseEnter(object sender, EventArgs e)
    {
      panel.BackColor = Color.LimeGreen;
      eventLabel.Text = "Mouse inside panel";
    }

    private void onMouseLeave(object sender, EventArgs e)
    {
      panel.BackColor = Color.White;
      eventLabel.Text = "Mouse outside panel";
    }

    private void onMouseMove(object sender, MouseEventArgs e)
    {
      if ((Panel)sender == panel &&
        e.X != mousePosition.X &&
        e.Y != mousePosition.Y
        )
      {
        mousePosition = new Point(e.X, e.Y);
        if (mouseDown)
          eventLabel.Text = $"Dragged at [{e.X}, {e.Y}]";
        else
          eventLabel.Text = $"Moved at [{e.X}, {e.Y}]";
      }
    }

    private void onMouseUp(object sender, MouseEventArgs e)
    {
      if ((Panel)sender == panel)
      {
        mouseDown = false;
        eventLabel.Text = $"Released at [{e.X}, {e.Y}]";
      }
    }
  }
}
