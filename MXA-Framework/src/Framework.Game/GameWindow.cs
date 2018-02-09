using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public abstract class GameWindow {
		public void EndScreenDeviceChange(string screenDeviceName) { throw new NotImplementedException( ); }
		public abstract void BeginScreenDeviceChange(bool willBeFullScreen);
		public abstract void EndScreenDeviceChange(string screenDeviceName, int clientWidth, int clientHeight);
		protected internal abstract void SetSupportedOrientations(DisplayOrientation orientations);
		protected abstract void SetTitle(string title);
		protected void OnActivated( ) { throw new NotImplementedException( ); }
		protected void OnClientSizeChanged( ) { throw new NotImplementedException( ); }
		protected void OnDeactivated( ) { throw new NotImplementedException( ); }
		protected void OnOrientationChanged( ) { throw new NotImplementedException( ); }
		protected void OnPaint( ) { throw new NotImplementedException( ); }
		protected void OnScreenDeviceNameChanged( ) { throw new NotImplementedException( ); }

		public string Title { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public abstract bool AllowUserResizing { get; set; }
		public abstract Rectangle ClientBounds { get; }
		public abstract DisplayOrientation CurrentOrientation { get; }
		public abstract IntPtr Handle { get; }
		public abstract string ScreenDeviceName { get; }

		public event EventHandler<EventArgs> Activated;
		public event EventHandler<EventArgs> ClientSizeChanged;
		public event EventHandler<EventArgs> Deactivated;
		public event EventHandler<EventArgs> OrientationChanged;
		public event EventHandler<EventArgs> Paint;
		public event EventHandler<EventArgs> ScreenDeviceNameChanged;
	}
}
