﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public class BoundingFrustum : IEquatable<BoundingFrustum> {
		public BoundingFrustum(Matrix value) { throw new NotImplementedException( ); }
		public ContainmentType Contains(BoundingBox box) { throw new NotImplementedException( ); }
		public ContainmentType Contains(BoundingFrustum frustum) { throw new NotImplementedException( ); }
		public ContainmentType Contains(BoundingSphere sphere) { throw new NotImplementedException( ); }
		public ContainmentType Contains(Vector3 point) { throw new NotImplementedException( ); }
		public void Contains(ref BoundingBox box, out ContainmentType result) { throw new NotImplementedException( ); }
		public void Contains(ref BoundingSphere sphere, out ContainmentType result) { throw new NotImplementedException( ); }
		public void Contains(ref Vector3 point, out ContainmentType result) { throw new NotImplementedException( ); }
		public bool Equals(BoundingFrustum other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public Vector3[] GetCorners( ) { throw new NotImplementedException( ); }
		public void GetCorners(Vector3[] corners) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public bool Intersects(BoundingBox box) { throw new NotImplementedException( ); }
		public bool Intersects(BoundingFrustum frustum) { throw new NotImplementedException( ); }
		public bool Intersects(BoundingSphere sphere) { throw new NotImplementedException( ); }
		public PlaneIntersectionType Intersects(Plane plane) { throw new NotImplementedException( ); }
		public float? Intersects(Ray ray) { throw new NotImplementedException( ); }
		public void Intersects(ref BoundingBox box, out bool result) { throw new NotImplementedException( ); }
		public void Intersects(ref BoundingSphere sphere, out bool result) { throw new NotImplementedException( ); }
		public void Intersects(ref Plane plane, out PlaneIntersectionType result) { throw new NotImplementedException( ); }
		public void Intersects(ref Ray ray, out float? result) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(BoundingFrustum a, BoundingFrustum b) { throw new NotImplementedException( ); }
		public static bool operator ==(BoundingFrustum a, BoundingFrustum b) { throw new NotImplementedException( ); }
		public Plane Bottom { get { throw new NotImplementedException( ); } }
		public Plane Far { get { throw new NotImplementedException( ); } }
		public Plane Left { get { throw new NotImplementedException( ); } }
		public Matrix Matrix { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Plane Near { get { throw new NotImplementedException( ); } }
		public Plane Right { get { throw new NotImplementedException( ); } }
		public Plane Top { get { throw new NotImplementedException( ); } }
		public const int CornerCount = 8;
	}
}
