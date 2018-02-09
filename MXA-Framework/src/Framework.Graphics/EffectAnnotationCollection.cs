using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class EffectAnnotationCollection : IEnumerable<EffectAnnotation> {
		public IEnumerator<EffectAnnotation> GetEnumerator( ) { throw new NotImplementedException( ); }
		IEnumerator IEnumerable.GetEnumerator( ) { throw new NotImplementedException( ); }
		public int Count { get { throw new NotImplementedException( ); } }
		public EffectAnnotation this[int index] { get { throw new NotImplementedException( ); } }
		public EffectAnnotation this[string name] { get { throw new NotImplementedException( ); } }
	}
}
