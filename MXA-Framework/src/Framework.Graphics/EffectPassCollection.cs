using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class EffectPassCollection : IEnumerable<EffectPass> {
		public IEnumerator<EffectPass> GetEnumerator( ) { throw new NotImplementedException( ); }
		IEnumerator IEnumerable.GetEnumerator( ) { throw new NotImplementedException( ); }
		public int Count { get { throw new NotImplementedException( ); } }
		public EffectPass this[int index] { get { throw new NotImplementedException( ); } }
		public EffectPass this[string name] { get { throw new NotImplementedException( ); } }
	}
}
