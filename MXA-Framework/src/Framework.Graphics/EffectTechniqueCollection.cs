using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class EffectTechniqueCollection : IEnumerable<EffectTechnique> {
		public IEnumerator<EffectTechnique> GetEnumerator( ) { throw new NotImplementedException( ); }
		IEnumerator IEnumerable.GetEnumerator( ) { throw new NotImplementedException( ); }
		public int Count { get { throw new NotImplementedException( ); } }
		public EffectTechnique this[int index] { get { throw new NotImplementedException( ); } }
		public EffectTechnique this[string name] { get { throw new NotImplementedException( ); } }
	}
}
