using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public class CurveKey : IEquatable<CurveKey>, IComparable<CurveKey> {
		public CurveKey(float position, float value) { throw new NotImplementedException( ); }
		public CurveKey(float position, float value, float tangentIn, float tangentOut) { throw new NotImplementedException( ); }
		public CurveKey(float position, float value, float tangentIn, float tangentOut, CurveContinuity continuity) { throw new NotImplementedException( ); }
		public CurveKey Clone( ) { throw new NotImplementedException( ); }
		public int CompareTo(CurveKey other) { throw new NotImplementedException( ); }
		public bool Equals(CurveKey other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public static bool operator !=(CurveKey a, CurveKey b) { throw new NotImplementedException( ); }
		public static bool operator ==(CurveKey a, CurveKey b) { throw new NotImplementedException( ); }
		public CurveContinuity Continuity { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float Position { get { throw new NotImplementedException( ); } }
		public float TangentIn { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float TangentOut { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float Value { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
