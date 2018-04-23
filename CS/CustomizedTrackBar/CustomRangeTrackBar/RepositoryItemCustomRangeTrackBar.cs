using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace CustomizedRangeTrackBar
{
    //The attribute that points to the registration method 
    [UserRepositoryItem("RegisterCustomRangeTrackBar")]
    class RepositoryItemCustomRangeTrackBar : RepositoryItemRangeTrackBar
    {
        static readonly object drawingTick = new object();
        private string tickDisplayText;

        // Static constructor should call registration method
        static RepositoryItemCustomRangeTrackBar() { RegisterCustomRangeTrackBar(); }

        public const string CustomRangeTrackBarName = "CustomRangeTrackBar";
        public override string EditorTypeName { get { return CustomRangeTrackBarName; } }

        public static void RegisterCustomRangeTrackBar()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(
                CustomRangeTrackBarName, typeof(CustomRangeTrackBar), typeof(RepositoryItemCustomRangeTrackBar),
                typeof(CustomRangeTrackBarViewInfo), new RangeTrackBarPainter(), true));
        }

        public event EventHandler DrawingTick
        {
            add { Events.AddHandler(RepositoryItemCustomRangeTrackBar.drawingTick, value); }
            remove { Events.AddHandler(RepositoryItemCustomRangeTrackBar.drawingTick, value); }
        }

        protected internal virtual void OnDrawingTick(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[RepositoryItemCustomRangeTrackBar.drawingTick];
            if (handler != null) handler(GetEventSender(), e);
        }

        public string TickDisplayText
        {
            set
            {
                tickDisplayText = value;
                RaisePropertiesChanged(EventArgs.Empty);
            }
            get
            {
                return tickDisplayText;
            }
        }

        // Override the Assign method
        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            base.Assign(item);
            RepositoryItemCustomRangeTrackBar source = item as RepositoryItemCustomRangeTrackBar;
            if (source == null) return;
            this.TickDisplayText = source.TickDisplayText;
            EndUpdate();
            Events.AddHandler(RepositoryItemCustomRangeTrackBar.drawingTick, source.Events[RepositoryItemCustomRangeTrackBar.drawingTick]);
        }
    }

    public class DrawingTickEventArgs : EventArgs
    {
        TrackBarObjectInfoArgs trackBarObject;
        int tickCount;

        public DrawingTickEventArgs(TrackBarObjectInfoArgs _trackBarObject, int _tickCount)
        {
            trackBarObject = _trackBarObject;
            tickCount = _tickCount;
        }

        public TrackBarObjectInfoArgs TrackBarObject { get { return trackBarObject; } }
        public int TickCount { get { return tickCount; } }
    }
}
