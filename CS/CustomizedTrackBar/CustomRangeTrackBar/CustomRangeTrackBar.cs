using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace CustomizedRangeTrackBar
{
    class CustomRangeTrackBar : RangeTrackBarControl
    {
        static CustomRangeTrackBar() { RepositoryItemCustomRangeTrackBar.RegisterCustomRangeTrackBar(); }
        public CustomRangeTrackBar() : base() { }

        public override string EditorTypeName { get { return RepositoryItemCustomRangeTrackBar.CustomRangeTrackBarName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomRangeTrackBar Properties
        { get { return base.Properties as RepositoryItemCustomRangeTrackBar; } }
    }
}
