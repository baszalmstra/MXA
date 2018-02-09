using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class EffectParameterCollection : IEnumerable<EffectParameter> {
		public IEnumerator<EffectParameter> GetEnumerator( ) { throw new NotImplementedException( ); }
		IEnumerator IEnumerable.GetEnumerator( ) { throw new NotImplementedException( ); }
		public EffectParameter GetParameterBySemantic(string semantic) { throw new NotImplementedException( ); }
		public int Count { get { throw new NotImplementedException( ); } }
		public EffectParameter this[int index] { get { throw new NotImplementedException( ); } }
		public EffectParameter this[string name] { get { throw new NotImplementedException( ); } }
	}
}
