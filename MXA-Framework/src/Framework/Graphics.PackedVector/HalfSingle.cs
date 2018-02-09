using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics.PackedVector {
	public struct HalfSingle : IPackedVector<ushort>, IPackedVector, IEquatable<HalfSingle> {
		public HalfSingle(float value) { throw new NotImplementedException( ); }

		public bool Equals(HalfSingle other) {throw new NotImplementedException(); }
		public override bool Equals(object obj) {throw new NotImplementedException(); }
		public override int GetHashCode( ) { throw new NotImplementedException();}
		public float ToSingle( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException();}
		public static bool operator !=(HalfSingle a, HalfSingle b) {throw new NotImplementedException(); }
		public static bool operator ==(HalfSingle a, HalfSingle b) {throw new NotImplementedException(); }

		public ushort PackedValue { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		void IPackedVector.PackFromVector4(Vector4 vector) { throw new NotImplementedException( ); }
		Vector4 IPackedVector.ToVector4( ) { throw new NotImplementedException( ); }
	}
}
