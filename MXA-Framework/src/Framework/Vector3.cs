using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Vector3 : IEquatable<Vector3> {
		public float X;
		public float Y;
		public float Z;

		public Vector3(float value) { throw new NotImplementedException( ); }
		public Vector3(float x, float y, float z) { throw new NotImplementedException( ); }
		public Vector3(Vector2 value, float z) { throw new NotImplementedException( ); }

		public static Vector3 Add(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2) { throw new NotImplementedException( ); }
		public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1, float amount2, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount) { throw new NotImplementedException( ); }
		public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float amount, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max) { throw new NotImplementedException( ); }
		public static void Clamp(ref Vector3 value1, ref Vector3 min, ref Vector3 max, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Cross(Vector3 vector1, Vector3 vector2) { throw new NotImplementedException( ); }
		public static void Cross(ref Vector3 vector1, ref Vector3 vector2, out Vector3 result) { throw new NotImplementedException( ); }
		public static float Distance(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result) { throw new NotImplementedException( ); }
		public static float DistanceSquared(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result) { throw new NotImplementedException( ); }
		public static Vector3 Divide(Vector3 value1, float value2) { throw new NotImplementedException( ); }
		public static Vector3 Divide(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Divide(ref Vector3 value1, float value2, out Vector3 result) { throw new NotImplementedException( ); }
		public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException( ); }
		public static float Dot(Vector3 vector1, Vector3 vector2) { throw new NotImplementedException( ); }
		public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result) { throw new NotImplementedException( ); }
		public bool Equals(Vector3 other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount) { throw new NotImplementedException( ); }
		public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result) { throw new NotImplementedException( ); }
		public float Length( ) { throw new NotImplementedException( ); }
		public float LengthSquared( ) { throw new NotImplementedException( ); }
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount) { throw new NotImplementedException( ); }
		public static void Lerp(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Max(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Min(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Multiply(Vector3 value1, float scaleFactor) { throw new NotImplementedException( ); }
		public static Vector3 Multiply(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result) { throw new NotImplementedException( ); }
		public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Negate(Vector3 value) { throw new NotImplementedException( ); }
		public static void Negate(ref Vector3 value, out Vector3 result) { throw new NotImplementedException( ); }
		public void Normalize( ) { throw new NotImplementedException( ); }
		public static Vector3 Normalize(Vector3 value) { throw new NotImplementedException( ); }
		public static void Normalize(ref Vector3 value, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Reflect(Vector3 vector, Vector3 normal) { throw new NotImplementedException( ); }
		public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount) { throw new NotImplementedException( ); }
		public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 Subtract(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static Vector3 Transform(Vector3 position, Matrix matrix) { throw new NotImplementedException( ); }
		public static Vector3 Transform(Vector3 value, Quaternion rotation) { throw new NotImplementedException( ); }
		public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException( ); }
		public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException( ); }
		public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray) { throw new NotImplementedException( ); }
		public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result) { throw new NotImplementedException( ); }
		public static Vector3 TransformNormal(Vector3 normal, Matrix matrix) { throw new NotImplementedException( ); }
		public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException( ); }
		public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray) { throw new NotImplementedException( ); }
		public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result) { throw new NotImplementedException( ); }

		public static bool operator !=(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static bool operator ==(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static Vector3 operator +(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static Vector3 operator -(Vector3 value) { throw new NotImplementedException( ); }
		public static Vector3 operator -(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static Vector3 operator *(float scaleFactor, Vector3 value) { throw new NotImplementedException( ); }
		public static Vector3 operator *(Vector3 value, float scaleFactor) { throw new NotImplementedException( ); }
		public static Vector3 operator *(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }
		public static Vector3 operator /(Vector3 value, float divider) { throw new NotImplementedException( ); }
		public static Vector3 operator /(Vector3 value1, Vector3 value2) { throw new NotImplementedException( ); }

		public static Vector3 Backward { get { throw new NotImplementedException( ); } }
		public static Vector3 Down { get { throw new NotImplementedException( ); } }
		public static Vector3 Forward { get { throw new NotImplementedException( ); } }
		public static Vector3 Left { get { throw new NotImplementedException( ); } }
		public static Vector3 One { get { throw new NotImplementedException( ); } }
		public static Vector3 Right { get { throw new NotImplementedException( ); } }
		public static Vector3 UnitX { get { throw new NotImplementedException( ); } }
		public static Vector3 UnitY { get { throw new NotImplementedException( ); } }
		public static Vector3 UnitZ { get { throw new NotImplementedException( ); } }
		public static Vector3 Up { get { throw new NotImplementedException( ); } }
		public static Vector3 Zero { get { throw new NotImplementedException( ); } }
	}
}
