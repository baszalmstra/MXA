using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class Artist : IEquatable<Artist>, IDisposable {
		public void Dispose( ) { throw new NotImplementedException( ); }
		public bool Equals(Artist other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Artist first, Artist second) { throw new NotImplementedException( ); }
		public static bool operator ==(Artist first, Artist second) { throw new NotImplementedException( ); }
		public AlbumCollection Albums { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } }
		public SongCollection Songs { get { throw new NotImplementedException( ); } }
	}
}
