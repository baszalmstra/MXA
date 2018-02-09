using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insma.Mxa.Framework.Graphics;

namespace Insma.Mxa.Framework {
	public class GraphicsDeviceManager : IGraphicsDeviceService, IDisposable, IGraphicsDeviceManager {
		public static readonly int DefaultBackBufferHeight;
		public static readonly int DefaultBackBufferWidth;

		public GraphicsDeviceManager(Game game) { throw new NotImplementedException( ); }

		public void ApplyChanges( ) { throw new NotImplementedException( ); }
		public void ToggleFullScreen( ) { throw new NotImplementedException( ); }
		protected virtual bool CanResetDevice(GraphicsDeviceInformation newDeviceInfo) { throw new NotImplementedException( ); }
		void IDisposable.Dispose( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool disposing) { throw new NotImplementedException( ); }
		protected virtual GraphicsDeviceInformation FindBestDevice(bool anySuitableDevice) { throw new NotImplementedException( ); }
		protected virtual void RankDevices(List<GraphicsDeviceInformation> foundDevices) { throw new NotImplementedException( ); }
		protected virtual void OnDeviceCreated(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnDeviceDisposing(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnDeviceReset(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnDeviceResetting(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnPreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs args) { throw new NotImplementedException( ); }
		
		bool IGraphicsDeviceManager.BeginDraw( ) { throw new NotImplementedException( ); }
		void IGraphicsDeviceManager.CreateDevice( ) { throw new NotImplementedException( ); }
		void IGraphicsDeviceManager.EndDraw( ) { throw new NotImplementedException( ); }

		public GraphicsDevice GraphicsDevice { get { throw new NotImplementedException( ); } }
		public GraphicsProfile GraphicsProfile { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool IsFullScreen { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool PreferMultiSampling { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public SurfaceFormat PreferredBackBufferFormat { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int PreferredBackBufferHeight { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int PreferredBackBufferWidth { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public DepthFormat PreferredDepthStencilFormat { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public DisplayOrientation SupportedOrientations { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool SynchronizeWithVerticalRetrace { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> DeviceCreated;
		public event EventHandler<EventArgs> DeviceDisposing;
		public event EventHandler<EventArgs> DeviceReset;
		public event EventHandler<EventArgs> DeviceResetting;
		public event EventHandler<EventArgs> Disposed;
		public event EventHandler<PreparingDeviceSettingsEventArgs> PreparingDeviceSettings;
	}
}
