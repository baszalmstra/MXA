using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Audio {
	public class SoundEffectInstance : IDisposable {
		public void Apply3D(AudioListener listener, AudioEmitter emitter) { throw new NotImplementedException( ); }
		public void Apply3D(AudioListener[] listeners, AudioEmitter emitter) { throw new NotImplementedException( ); }
		public void Dispose( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool disposing) { throw new NotImplementedException( ); }
		public void Pause( ) { throw new NotImplementedException( ); }
		public virtual void Play( ) { throw new NotImplementedException( ); }
		public void Resume( ) { throw new NotImplementedException( ); }
		public void Stop( ) { throw new NotImplementedException( ); }
		public void Stop(bool immediate) { throw new NotImplementedException( ); }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public virtual bool IsLooped { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float Pan { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float Pitch { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public SoundState State { get { throw new NotImplementedException( ); } }
		public float Volume { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
