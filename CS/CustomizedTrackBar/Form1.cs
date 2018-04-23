using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Drawing;

namespace CustomizedTrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customTrackBar1_Properties_DrawingTick(object sender, EventArgs e)
        {
            CustomizedTrackBar.DrawingTickEventArgs ee = e as DrawingTickEventArgs;
            TrackBarObjectInfoArgs tbObject = ee.TrackBarObject;
            CustomizedTrackBar.CustomTrackBarViewInfo vi = tbObject.ViewInfo as CustomizedTrackBar.CustomTrackBarViewInfo;
            vi.RepositoryItem.TickDisplayText = ee.TickCount.ToString();
        }

        private void customRangeTrackBar1_Properties_DrawingTick(object sender, EventArgs e)
        {
            CustomizedRangeTrackBar.DrawingTickEventArgs ee = e as CustomizedRangeTrackBar.DrawingTickEventArgs;
            TrackBarObjectInfoArgs tbObject = ee.TrackBarObject;
            CustomizedRangeTrackBar.CustomRangeTrackBarViewInfo vi = tbObject.ViewInfo as CustomizedRangeTrackBar.CustomRangeTrackBarViewInfo;
            vi.RepositoryItem.TickDisplayText =  Math.Pow(ee.TickCount, 2).ToString();
        }
    }
}
