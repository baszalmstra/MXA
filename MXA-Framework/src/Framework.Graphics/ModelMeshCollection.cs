using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class ModelMeshCollection : ReadOnlyCollection<ModelMesh> {
		internal ModelMeshCollection(IList<ModelMesh> list) : base(list) { throw new NotImplementedException( ); }

		public new ModelMeshCollection.Enumerator GetEnumerator( ) { throw new NotImplementedException( ); }
		public bool TryGetValue(string meshName, out ModelMesh value) { throw new NotImplementedException( ); }

		public ModelMesh this[string meshName] { get { throw new NotImplementedException( ); } }

		public struct Enumerator : IEnumerator<ModelMesh>, IDisposable, IEnumerator {
			public void Dispose( ) { throw new NotImplementedException( ); }
			public bool MoveNext( ) { throw new NotImplementedException( ); }

			public ModelMesh Current { get { throw new NotImplementedException( ); } }
			
			void IEnumerator.Reset( ) { throw new NotImplementedException( ); }
			object IEnumerator.Current { get { throw new NotImplementedException( ); } }
		}
	}
}
