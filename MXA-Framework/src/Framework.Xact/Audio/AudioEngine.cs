using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Audio {
	[Obsolete("XACT is no more supported. Use Insma.Mxa.Framework.Audio.dll", true)]
	public class AudioEngine : IDisposable {
		#region IDisposable Members

		public void Dispose( ) {
			throw new NotImplementedException( );
		}

		#endregion
	}
}
