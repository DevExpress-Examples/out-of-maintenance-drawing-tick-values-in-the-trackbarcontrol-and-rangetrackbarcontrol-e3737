using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace CustomizedTrackBar
{
    class CustomTrackBar : TrackBarControl
    {
        static CustomTrackBar() { RepositoryItemCustomTrackBar.RegisterCustomTrackBar(); }

        public CustomTrackBar() : base() { }

        public override string EditorTypeName { get { return RepositoryItemCustomTrackBar.CustomTrackBarName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomTrackBar Properties
        { get { return base.Properties as RepositoryItemCustomTrackBar; } }
    }
}
