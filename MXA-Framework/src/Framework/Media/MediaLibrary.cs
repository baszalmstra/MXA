using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class MediaLibrary : IDisposable {
		public MediaLibrary( ) { throw new NotImplementedException( ); }
		public MediaLibrary(MediaSource mediaSource) { throw new NotImplementedException( ); }

		public void Dispose( ) { throw new NotImplementedException( ); }
		public Picture GetPictureFromToken(string token) { throw new NotImplementedException( ); }
		public Picture SavePicture(string name, byte[] imageBuffer) { throw new NotImplementedException( ); }
		public Picture SavePicture(string name, System.IO.Stream source) { throw new NotImplementedException( ); }
		public AlbumCollection Albums { get { throw new NotImplementedException( ); } }
		public ArtistCollection Artists { get { throw new NotImplementedException( ); } }
		public GenreCollection Genres { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public MediaSource MediaSource { get { throw new NotImplementedException( ); } }
		public PictureCollection Pictures { get { throw new NotImplementedException( ); } }
		public PlaylistCollection Playlists { get { throw new NotImplementedException( ); } }
		public PictureAlbum RootPictureAlbum { get { throw new NotImplementedException( ); } }
		public PictureCollection SavedPictures { get { throw new NotImplementedException( ); } }
		public SongCollection Songs { get { throw new NotImplementedException( ); } }
	}
}
