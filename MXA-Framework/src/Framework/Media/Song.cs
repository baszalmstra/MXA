using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class Song : IEquatable<Song>, IDisposable {
		public void Dispose( ) { throw new NotImplementedException( ); }
		public bool Equals(Song other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public static Song FromUri(string name, System.Uri uri) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Song first, Song second) { throw new NotImplementedException( ); }
		public static bool operator ==(Song first, Song second) { throw new NotImplementedException( ); }
		public Album Album { get { throw new NotImplementedException( ); } }
		public Artist Artist { get { throw new NotImplementedException( ); } }
		public System.TimeSpan Duration { get { throw new NotImplementedException( ); } }
		public Genre Genre { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public bool IsProtected { get { throw new NotImplementedException( ); } }
		public bool IsRated { get { throw new NotImplementedException( ); } }
		public string Name { get { throw new NotImplementedException( ); } }
		public int PlayCount { get { throw new NotImplementedException( ); } }
		public int Rating { get { throw new NotImplementedException( ); } }
		public int TrackNumber { get { throw new NotImplementedException( ); } }
	}
}
