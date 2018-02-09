using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class DisplayModeCollection : IEnumerable<DisplayMode>, IEnumerable {
		public IEnumerator<DisplayMode> GetEnumerator( ) { throw new NotImplementedException( ); }
		public IEnumerable<DisplayMode> this[SurfaceFormat format] { get { throw new NotImplementedException( ); } }
		IEnumerator IEnumerable.GetEnumerator( ) { throw new NotImplementedException( ); }
	}
}
