using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics.PackedVector {
	public struct Alpha8 : IPackedVector<byte>, IPackedVector, IEquatable<Alpha8> {
		public Alpha8(float alpha) { throw new NotImplementedException(); }

		public bool Equals(Alpha8 other) {throw new NotImplementedException(); }
		public override bool Equals(object obj) {throw new NotImplementedException(); }
		public override int GetHashCode( ) { throw new NotImplementedException();}
		public float ToAlpha( ) { throw new NotImplementedException();}
		public override string ToString( ) { throw new NotImplementedException();}
		public static bool operator !=(Alpha8 a, Alpha8 b) {throw new NotImplementedException(); }
		public static bool operator ==(Alpha8 a, Alpha8 b) {throw new NotImplementedException(); }
	
		public byte PackedValue { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		void IPackedVector.PackFromVector4(Vector4 vector) { throw new NotImplementedException( ); }
		Vector4 IPackedVector.ToVector4( ) { throw new NotImplementedException( ); }
	}
}
