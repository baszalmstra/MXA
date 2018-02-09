using System;
using Insma.Mxa.Framework.Graphics;

namespace Insma.Mxa.Framework.Media {
	public sealed class VideoPlayer : IDisposable {
		private bool _isDisposed;
		private TimeSpan _playPosition;
		private MediaState _state;
		private Video _video;

		public VideoPlayer( ) {

		}

		public void Dispose( ) { }
		public Texture2D GetTexture( ) { return new Texture2D( ); }
		public void Play(Video video) { }
		public void Pause( ) { }
		public void Resume( ) { }
		public void Stop( ) { }

		public bool IsDisposed { get { return this._isDisposed; } }
		public bool IsLooped { get; set; }
		public bool IsMuted { get; set; }
		public TimeSpan PlayPosition { get { return this._playPosition; } }
		public MediaState State { get { return this._state; } }
		public Video Video { get { return this._video; } }
		public float Volume { get; set; }
	}
}
