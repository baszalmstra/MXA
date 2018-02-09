using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics.PackedVector {
	public struct Bgr565 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgr565> {
		public Bgr565(float x, float y, float z) { throw new NotImplementedException( ); }
		public Bgr565(Vector3 vector) { throw new NotImplementedException( ); }
		public bool Equals(Bgr565 other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public Vector3 ToVector3( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Bgr565 a, Bgr565 b) { throw new NotImplementedException( ); }
		public static bool operator ==(Bgr565 a, Bgr565 b) { throw new NotImplementedException( ); }

		public ushort PackedValue { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		void IPackedVector.PackFromVector4(Vector4 vector) { throw new NotImplementedException( ); }
		Vector4 IPackedVector.ToVector4( ) { throw new NotImplementedException( ); }
	}
}
