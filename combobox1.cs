using System;
using System.Drawing;
using System.Windows.Forms;

public class combobox1 : ComboBox
{
    // Constructor
    public combobox1 ()
    {
        DrawMode = DrawMode.OwnerDrawFixed;
        DropDownStyle = ComboBoxStyle.DropDownList;
        BackColor = Color.FromArgb(211, 251, 216); // Set background color RGB(211, 251, 216)
        ForeColor = Color.FromArgb(41, 43, 47);   // Set text color RGB(41, 43, 47)
    }

    // Override OnDrawItem method to customize item drawing
    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        if (e.Index >= 0)
        {
            // Draw background
            e.DrawBackground();

            // Get item text
            string text = Items[e.Index].ToString();

            // Create text brush
            Brush brush = new SolidBrush(ForeColor);

            // Draw text
            e.Graphics.DrawString(text, e.Font, brush, e.Bounds, StringFormat.GenericDefault);

            // Dispose of objects
            brush.Dispose();

            // Draw focus rectangle if item is selected
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.DrawFocusRectangle();
        }
        base.OnDrawItem(e);
    }
}