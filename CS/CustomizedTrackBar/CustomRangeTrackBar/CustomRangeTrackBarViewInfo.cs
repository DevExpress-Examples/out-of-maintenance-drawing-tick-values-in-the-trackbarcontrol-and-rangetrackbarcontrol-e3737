using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.LookAndFeel;

namespace CustomizedRangeTrackBar
{
    class CustomRangeTrackBarViewInfo : RangeTrackBarViewInfo
    {
        public CustomRangeTrackBarViewInfo(RepositoryItem item) : base(item) { }
        public RepositoryItemCustomRangeTrackBar RepositoryItem
        {
            get { return this.Item as RepositoryItemCustomRangeTrackBar; }
        }

        public override DevExpress.XtraEditors.Drawing.TrackBarObjectPainter GetTrackPainter()
        {
            //if (IsPrinting)
            //    return new RangeTrackBarObjectPainter();
            //if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.WindowsXP)
            //    return new RangeTrackBarObjectPainter();
            //if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
            return new SkinCustomRangeTrackBarObjectPainter(LookAndFeel.ActiveLookAndFeel);
            //if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Office2003)
            //    return new Office2003RangeTrackBarObjectPainter();
            //return new RangeTrackBarObjectPainter();
        }
    }
}
