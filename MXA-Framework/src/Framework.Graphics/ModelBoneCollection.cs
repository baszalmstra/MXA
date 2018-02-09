using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public sealed class ModelBoneCollection : ReadOnlyCollection<ModelBone> {
		internal ModelBoneCollection(IList<ModelBone> list) : base(list) { throw new NotImplementedException( ); }

		public new ModelBoneCollection.Enumerator GetEnumerator( ) { throw new NotImplementedException( ); }
		public bool TryGetValue(string boneName, out ModelBone value) { throw new NotImplementedException( ); }

		public ModelBone this[string boneName] { get { throw new NotImplementedException( ); } }

		public struct Enumerator : IEnumerator<ModelBone>, IDisposable, IEnumerator {
			public void Dispose( ) { throw new NotImplementedException( ); }
			public bool MoveNext( ) { throw new NotImplementedException( ); }

			public ModelBone Current { get { throw new NotImplementedException( ); } }

			void IEnumerator.Reset( ) { throw new NotImplementedException( ); }
			object IEnumerator.Current { get { throw new NotImplementedException( ); } }
		}
	}
}
