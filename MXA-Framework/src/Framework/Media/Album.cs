using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class Album : IEquatable<Album>, IDisposable {
		public void Dispose( ) { throw new NotImplementedException( ); }
		public bool Equals(Album other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public Stream GetAlbumArt( ) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public Stream GetThumbnail( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Album first, Album second) { throw new NotImplementedException( ); }
		public static bool operator ==(Album first, Album second) { throw new NotImplementedException( ); }
		public Artist Artist { get { throw new NotImplementedException( ); } }
		public TimeSpan Duration { get { throw new NotImplementedException( ); } }
		public Genre Genre { get { throw new NotImplementedException( ); } }
		public bool HasArt { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } }
		public SongCollection Songs { get { throw new NotImplementedException( ); } }
	}
}
