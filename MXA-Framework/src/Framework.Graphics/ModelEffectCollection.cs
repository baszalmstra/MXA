using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class ModelEffectCollection : ReadOnlyCollection<Effect> {
		internal ModelEffectCollection(IList<Effect> list) : base(list) { throw new NotImplementedException( ); }

		public new ModelEffectCollection.Enumerator GetEnumerator( ) { throw new NotImplementedException( ); }

		public struct Enumerator : IEnumerator<Effect>, IDisposable, IEnumerator {
			public void Dispose( ) { throw new NotImplementedException( ); }
			public bool MoveNext( ) { throw new NotImplementedException( ); }

			public Effect Current { get { throw new NotImplementedException( ); } }

			void IEnumerator.Reset( ) { throw new NotImplementedException( ); }
			object IEnumerator.Current { get { throw new NotImplementedException( ); } }
		}
	}
}
