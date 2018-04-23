using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace CustomizedTrackBar
{
    //The attribute that points to the registration method 
    [UserRepositoryItem("RegisterCustomTrackBar")]
    class RepositoryItemCustomTrackBar : RepositoryItemTrackBar
    {
        static readonly object drawingTick = new object();
        private string tickDisplayText;

        // Static constructor should call registration method
        static RepositoryItemCustomTrackBar() { RegisterCustomTrackBar(); }

        public const string CustomTrackBarName = "CustomTrackBar";
        public override string EditorTypeName { get { return CustomTrackBarName; } }

        public static void RegisterCustomTrackBar()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(
                CustomTrackBarName, typeof(CustomTrackBar), typeof(RepositoryItemCustomTrackBar),
                typeof(CustomTrackBarViewInfo), new TrackBarPainter(), true));
        }

        public event EventHandler DrawingTick
        {
            add { Events.AddHandler(RepositoryItemCustomTrackBar.drawingTick, value); }
            remove { Events.AddHandler(RepositoryItemCustomTrackBar.drawingTick, value); }
        }

        protected internal virtual void OnDrawingTick(EventArgs e) 
        {
			EventHandler handler = (EventHandler)Events[RepositoryItemCustomTrackBar.drawingTick];
			if(handler != null) handler(GetEventSender(), e);
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
            RepositoryItemCustomTrackBar source = item as RepositoryItemCustomTrackBar;
            if (source == null) return;
            this.TickDisplayText = source.TickDisplayText;
            EndUpdate();
            Events.AddHandler(RepositoryItemCustomTrackBar.drawingTick, source.Events[RepositoryItemCustomTrackBar.drawingTick]);
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
