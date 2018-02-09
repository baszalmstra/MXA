using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class ModelMeshPartCollection : ReadOnlyCollection<ModelMeshPart> {
		internal ModelMeshPartCollection(IList<ModelMeshPart> list) : base(list) { throw new NotImplementedException( ); }

		public new ModelMeshPartCollection.Enumerator GetEnumerator( ) { throw new NotImplementedException( ); }

		public struct Enumerator : IEnumerator<ModelMeshPart>, IDisposable, IEnumerator {
			public void Dispose( ) { throw new NotImplementedException( ); }
			public bool MoveNext( ) { throw new NotImplementedException( ); }

			public ModelMeshPart Current { get { throw new NotImplementedException( ); } }

			void IEnumerator.Reset( ) { throw new NotImplementedException( ); }
			object IEnumerator.Current { get { throw new NotImplementedException( ); } }
		}
	}
}
