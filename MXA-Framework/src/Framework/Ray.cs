using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Ray : IEquatable<Ray> {
		public Vector3 Position;
		public Vector3 Direction;

		public Ray(Vector3 position, Vector3 direction) { this.Position = position; this.Direction = direction; }
		public bool Equals(Ray other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public float? Intersects(BoundingBox box) { throw new NotImplementedException( ); }
		public float? Intersects(BoundingFrustum frustum) { throw new NotImplementedException( ); }
		public float? Intersects(BoundingSphere sphere) { throw new NotImplementedException( ); }
		public float? Intersects(Plane plane) { throw new NotImplementedException( ); }
		public void Intersects(ref BoundingBox box, out float? result) { throw new NotImplementedException( ); }
		public void Intersects(ref BoundingSphere sphere, out float? result) { throw new NotImplementedException( ); }
		public void Intersects(ref Plane plane, out float? result) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Ray a, Ray b) { throw new NotImplementedException( ); }
		public static bool operator ==(Ray a, Ray b) { throw new NotImplementedException( ); }
	}
}
