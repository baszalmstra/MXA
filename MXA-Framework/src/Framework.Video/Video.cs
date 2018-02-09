using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Media {
	public sealed class Video {
		private TimeSpan _duration;
		private float _framesPerSecond;
		private int _height;
		private VideoSoundtrackType _videoSoundtrackType;
		private int _width;

		public TimeSpan Duration { get { return this._duration; } }
		public float FramesPerSecond { get { return this._framesPerSecond; } }
		public int Height { get { return this._height; } }
		public VideoSoundtrackType VideoSoundtrackType { get { return this._videoSoundtrackType; } }
		public int Width { get { return this._width; } }
	}
}
