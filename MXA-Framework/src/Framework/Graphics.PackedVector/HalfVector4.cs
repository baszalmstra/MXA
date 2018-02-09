using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics.PackedVector {
	public struct HalfVector4 : IPackedVector<ulong>, IPackedVector, IEquatable<HalfVector4> {
		public HalfVector4(float x, float y, float z, float w) { throw new NotImplementedException( ); }
		public HalfVector4(Vector4 vector) { throw new NotImplementedException( ); }
		public bool Equals(HalfVector4 other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public Vector4 ToVector4( ) { throw new NotImplementedException( ); }
		public static bool operator !=(HalfVector4 a, HalfVector4 b) { throw new NotImplementedException( ); }
		public static bool operator ==(HalfVector4 a, HalfVector4 b) { throw new NotImplementedException( ); }

		public ulong PackedValue { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		void IPackedVector.PackFromVector4(Vector4 vector) { throw new NotImplementedException( ); }
		Vector4 IPackedVector.ToVector4( ) { throw new NotImplementedException( ); }
	}
}
