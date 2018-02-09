using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class GraphicsAdapter {
		public bool IsProfileSupported(GraphicsProfile graphicsProfile) { throw new NotImplementedException( ); }
		public bool QueryBackBufferFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount) { throw new NotImplementedException( ); }
		public bool QueryRenderTargetFormat(GraphicsProfile graphicsProfile, SurfaceFormat format, DepthFormat depthFormat, int multiSampleCount, out SurfaceFormat selectedFormat, out DepthFormat selectedDepthFormat, out int selectedMultiSampleCount) { throw new NotImplementedException( ); }

		public static ReadOnlyCollection<GraphicsAdapter> Adapters { get { throw new NotImplementedException( ); } }
		public DisplayMode CurrentDisplayMode { get { throw new NotImplementedException( ); } }
		public static GraphicsAdapter DefaultAdapter { get { throw new NotImplementedException( ); } }
		public string Description { get { throw new NotImplementedException( ); } }
		public int DeviceId { get { throw new NotImplementedException( ); } }
		public string DeviceName { get { throw new NotImplementedException( ); } }
		public bool IsDefaultAdapter { get { throw new NotImplementedException( ); } }
		public bool IsWideScreen { get { throw new NotImplementedException( ); } }
		public IntPtr MonitorHandle { get { throw new NotImplementedException( ); } }
		public int Revision { get { throw new NotImplementedException( ); } }
		public int SubSystemId { get { throw new NotImplementedException( ); } }
		public DisplayModeCollection SupportedDisplayModes { get { throw new NotImplementedException( ); } }
		public static bool UseNullDevice { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public static bool UseReferenceDevice { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int VendorId { get { throw new NotImplementedException( ); } }
	}
}
