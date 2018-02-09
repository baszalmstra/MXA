using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Plane : IEquatable<Plane> {
		public float D;
		public Vector3 Normal;

		public Plane(float a, float b, float c, float d) { throw new NotImplementedException( ); }
		public Plane(Vector3 normal, float d) { throw new NotImplementedException( ); }
		public Plane(Vector3 point1, Vector3 point2, Vector3 point3) { throw new NotImplementedException( ); }
		public Plane(Vector4 value) { throw new NotImplementedException( ); }
		public float Dot(Vector4 value) { throw new NotImplementedException( ); }
		public void Dot(ref Vector4 value, out float result) { throw new NotImplementedException( ); }
		public float DotCoordinate(Vector3 value) { throw new NotImplementedException( ); }
		public void DotCoordinate(ref Vector3 value, out float result) { throw new NotImplementedException( ); }
		public float DotNormal(Vector3 value) { throw new NotImplementedException( ); }
		public void DotNormal(ref Vector3 value, out float result) { throw new NotImplementedException( ); }
		public bool Equals(Plane other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public PlaneIntersectionType Intersects(BoundingBox box) { throw new NotImplementedException( ); }
		public PlaneIntersectionType Intersects(BoundingFrustum frustum) { throw new NotImplementedException( ); }
		public PlaneIntersectionType Intersects(BoundingSphere sphere) { throw new NotImplementedException( ); }
		public void Intersects(ref BoundingBox box, out PlaneIntersectionType result) { throw new NotImplementedException( ); }
		public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result) { throw new NotImplementedException( ); }
		public void Normalize( ) { throw new NotImplementedException( ); }
		public static Plane Normalize(Plane value) { throw new NotImplementedException( ); }
		public static void Normalize(ref Plane value, out Plane result) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static Plane Transform(Plane plane, Matrix matrix) { throw new NotImplementedException( ); }
		public static Plane Transform(Plane plane, Quaternion rotation) { throw new NotImplementedException( ); }
		public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result) { throw new NotImplementedException( ); }
		public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result) { throw new NotImplementedException( ); }
		public static bool operator !=(Plane lhs, Plane rhs) { throw new NotImplementedException( ); }
		public static bool operator ==(Plane lhs, Plane rhs) { throw new NotImplementedException( ); }
	}
}
