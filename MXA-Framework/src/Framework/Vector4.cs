using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Vector4 : IEquatable<Vector4> {
		public float X;
		public float Y;
		public float Z;
		public float W;

		public Vector4(float value) { throw new NotImplementedException( ); }
		public Vector4(float x, float y, float z, float w) { throw new NotImplementedException( ); }
		public Vector4(Vector2 value, float z, float w) { throw new NotImplementedException( ); }
		public Vector4(Vector3 value, float w) { throw new NotImplementedException( ); }
		
		public static Vector4 Add(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2) { throw new NotImplementedException( ); }
		public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount) { throw new NotImplementedException( ); }
		public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max) { throw new NotImplementedException( ); }
		public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result) { throw new NotImplementedException( ); }
		public static float Distance(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result) { throw new NotImplementedException( ); }
		public static float DistanceSquared(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result) { throw new NotImplementedException( ); }
		public static Vector4 Divide(Vector4 value1, float divider) { throw new NotImplementedException( ); }
		public static Vector4 Divide(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Divide(ref Vector4 value1, float divider, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException( ); }	
		public static float Dot(Vector4 vector1, Vector4 vector2) { throw new NotImplementedException( ); }
		public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result) { throw new NotImplementedException( ); }
		public bool Equals(Vector4 other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount) { throw new NotImplementedException( ); }
		public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result) { throw new NotImplementedException( ); }
		public float Length( ) { throw new NotImplementedException( ); }
		public float LengthSquared( ) { throw new NotImplementedException( ); }
		public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount) { throw new NotImplementedException( ); }
		public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Max(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Min(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Multiply(Vector4 value1, float scaleFactor) { throw new NotImplementedException( ); }
		public static Vector4 Multiply(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Negate(Vector4 value) { throw new NotImplementedException( ); }
		public static void Negate(ref Vector4 value, out Vector4 result) { throw new NotImplementedException( ); }
		public void Normalize( ) { throw new NotImplementedException( ); }
		public static Vector4 Normalize(Vector4 vector) { throw new NotImplementedException( ); }
		public static void Normalize(ref Vector4 vector, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount) { throw new NotImplementedException( ); }
		public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result) { throw new NotImplementedException( ); }
		public static Vector4 Subtract(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static Vector4 Transform(Vector2 position, Matrix matrix) { throw new NotImplementedException( ); }
		public static Vector4 Transform(Vector2 value, Quaternion rotation) { throw new NotImplementedException( ); }
		public static Vector4 Transform(Vector3 position, Matrix matrix) { throw new NotImplementedException( ); }
		public static Vector4 Transform(Vector3 value, Quaternion rotation) { throw new NotImplementedException( ); }
		public static Vector4 Transform(Vector4 vector, Matrix matrix) { throw new NotImplementedException( ); }
		public static Vector4 Transform(Vector4 value, Quaternion rotation) { throw new NotImplementedException( ); }
		public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException( ); }
		public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length) { throw new NotImplementedException( ); }
		public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray) { throw new NotImplementedException( ); }
		public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result) { throw new NotImplementedException( ); }
		public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result) { throw new NotImplementedException( ); }

		public static bool operator !=(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static bool operator ==(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static Vector4 operator +(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static Vector4 operator -(Vector4 value) { throw new NotImplementedException( ); }
		public static Vector4 operator -(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static Vector4 operator *(float scaleFactor, Vector4 value1) { throw new NotImplementedException( ); }
		public static Vector4 operator *(Vector4 value1, float scaleFactor) { throw new NotImplementedException( ); }
		public static Vector4 operator *(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }
		public static Vector4 operator /(Vector4 value1, float divider) { throw new NotImplementedException( ); }
		public static Vector4 operator /(Vector4 value1, Vector4 value2) { throw new NotImplementedException( ); }

		public static Vector4 One { get { throw new NotImplementedException( ); } }
		public static Vector4 UnitW { get { throw new NotImplementedException( ); } }
		public static Vector4 UnitX { get { throw new NotImplementedException( ); } }
		public static Vector4 UnitY { get { throw new NotImplementedException( ); } }
		public static Vector4 UnitZ { get { throw new NotImplementedException( ); } }
		public static Vector4 Zero { get { throw new NotImplementedException( ); } }
	}
}
