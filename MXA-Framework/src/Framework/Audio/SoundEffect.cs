using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Audio {
	public sealed class SoundEffect : IDisposable {
		public SoundEffect(byte[] buffer, int offset, int count, int sampleRate, AudioChannels channels, int loopStart, int loopLength) { throw new NotImplementedException( ); }
		public SoundEffect(byte[] buffer, int sampleRate, AudioChannels channels) { throw new NotImplementedException( ); }

		public SoundEffectInstance CreateInstance( ) { throw new NotImplementedException( ); }
		public void Dispose( ) { throw new NotImplementedException( ); }
		public static SoundEffect FromStream(System.IO.Stream stream) { throw new NotImplementedException( ); }
		public static TimeSpan GetSampleDuration(int sizeInBytes, int sampleRate, AudioChannels channels) { throw new NotImplementedException( ); }
		public static int GetSampleSizeInBytes(System.TimeSpan duration, int sampleRate, AudioChannels channels) { throw new NotImplementedException( ); }
		public bool Play( ) { throw new NotImplementedException( ); }
		public bool Play(float volume, float pitch, float pan) { throw new NotImplementedException( ); }
		public static float DistanceScale { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public static float DopplerScale { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public System.TimeSpan Duration { get { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public static float MasterVolume { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public string Name { get; set; }
		public static float SpeedOfSound { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
