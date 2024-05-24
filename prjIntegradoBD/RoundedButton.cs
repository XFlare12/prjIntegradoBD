using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int borderRadius = 20; // Ajuste este valor conforme necessário

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        GraphicsPath graphicsPath = new GraphicsPath();
        graphicsPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        graphicsPath.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        graphicsPath.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        graphicsPath.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
        graphicsPath.CloseAllFigures();
        this.Region = new Region(graphicsPath);
    }
}
