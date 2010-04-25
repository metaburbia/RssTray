using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RSSTray
{
    public partial class RssListView : ListView
    {
        public RssListView() : base()
        {
            OwnerDraw = true;
            HeaderStyle = ColumnHeaderStyle.None;
       
            DoubleBuffered = true;
            this.DrawItem += new DrawListViewItemEventHandler(RssListView_DrawItem);
            this.DrawSubItem +=new DrawListViewSubItemEventHandler(RssListView_DrawSubItem);
            this.View = View.Details;
        }


        private void RssListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                // e.Graphics.FillRectangle(Brushes.Maroon, e.Bounds);
                e.DrawFocusRectangle();
            }
            else
            {
                // Draw the background for an unselected item.
                /*using (LinearGradientBrush brush =
                    new LinearGradientBrush(e.Bounds, Color.Orange,
                    Color.Maroon, LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }*/
            }



        }

        private void RssListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
           

            if (e.ColumnIndex == 1)
            {

                e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
            }
            else
            {
                //e.Graphics.DrawString(e.SubItem.Text, Font, Brushes.Red, e.Bounds);

                e.DrawDefault = true;
                //e.Graphics.DrawString(e.SubItem.Text,Font,Brushes.Black,e.Bounds);
            }

        }
    }
}
