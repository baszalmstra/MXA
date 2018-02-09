using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class PictureAlbum : IEquatable<PictureAlbum>, IDisposable {
		public void Dispose( ) { throw new NotImplementedException( ); }
		public bool Equals(PictureAlbum other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(PictureAlbum first, PictureAlbum second) { throw new NotImplementedException( ); }
		public static bool operator ==(PictureAlbum first, PictureAlbum second) { throw new NotImplementedException( ); }
		public PictureAlbumCollection Albums { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } }
		public PictureAlbum Parent { get { throw new NotImplementedException( ); } }
		public PictureCollection Pictures { get { throw new NotImplementedException( ); } }

	}
}
