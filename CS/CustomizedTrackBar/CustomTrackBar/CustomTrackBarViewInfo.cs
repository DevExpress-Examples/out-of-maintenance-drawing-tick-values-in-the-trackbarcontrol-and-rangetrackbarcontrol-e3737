using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.LookAndFeel;

namespace CustomizedTrackBar
{
    class CustomTrackBarViewInfo : TrackBarViewInfo
    {
        public CustomTrackBarViewInfo(RepositoryItem item) : base(item) { }

        public RepositoryItemCustomTrackBar RepositoryItem
        { get { return this.Item as RepositoryItemCustomTrackBar; } }

        public override TrackBarObjectPainter GetTrackPainter()
        {
            //if (IsPrinting)
            //    return new TrackBarObjectPainter();
            //if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.WindowsXP)
            //    return new WindowsXPTrackBarObjectPainter();
            //if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
            return new SkinCustomTrackBarObjectPainter(LookAndFeel.ActiveLookAndFeel);
            //if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Office2003)
            //    return new Office2003TrackBarObjectPainter();
            //return new TrackBarObjectPainter();
        }
    }
}
