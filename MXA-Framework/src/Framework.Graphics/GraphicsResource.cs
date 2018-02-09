using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public abstract class GraphicsResource : IDisposable {
		public GraphicsDevice _parent;

		public void Dispose( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool disposing) { throw new NotImplementedException( ); }
		protected void raise_Disposing(object sender, EventArgs eventArgs) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }

		public GraphicsDevice GraphicsDevice { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public object Tag { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> Disposing;
	}
}
