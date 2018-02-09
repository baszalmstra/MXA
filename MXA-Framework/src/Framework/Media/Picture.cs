using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class Picture : IEquatable<Picture>, IDisposable {
		public void Dispose( ) { throw new NotImplementedException( ); }
		public bool Equals(Picture other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public Stream GetImage( ) { throw new NotImplementedException( ); }
		public Stream GetThumbnail( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Picture first, Picture second) { throw new NotImplementedException( ); }
		public static bool operator ==(Picture first, Picture second) { throw new NotImplementedException( ); }
		public PictureAlbum Album { get { throw new NotImplementedException( ); } }
		public DateTime Date { get { throw new NotImplementedException( ); } }
		public int Height { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } }
		public int Width { get { throw new NotImplementedException( ); } }
	}
}
