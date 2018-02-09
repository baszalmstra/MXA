using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics.PackedVector {
	public struct Rg32 : IPackedVector<uint>, IPackedVector, IEquatable<Rg32> {
		public Rg32(float x, float y) { throw new NotImplementedException( ); }
		public Rg32(Vector2 vector) { throw new NotImplementedException( ); }
		public bool Equals(Rg32 other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public Vector2 ToVector2( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Rg32 a, Rg32 b) { throw new NotImplementedException( ); }
		public static bool operator ==(Rg32 a, Rg32 b) { throw new NotImplementedException( ); }

		public uint PackedValue { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		void IPackedVector.PackFromVector4(Vector4 vector) { throw new NotImplementedException( ); }
		Vector4 IPackedVector.ToVector4( ) { throw new NotImplementedException( ); }
	}
}
