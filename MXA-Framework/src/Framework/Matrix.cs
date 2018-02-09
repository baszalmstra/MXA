using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Matrix : IEquatable<Matrix> {
		public float M11;
		public float M12;
		public float M13;
		public float M14;
		public float M21;
		public float M22;
		public float M23;
		public float M24;
		public float M31;
		public float M32;
		public float M33;
		public float M34;
		public float M41;
		public float M42;
		public float M43;
		public float M44;

		public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) { throw new NotImplementedException( ); }

		public static Matrix Add(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector) { throw new NotImplementedException( ); }
		public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector) { throw new NotImplementedException( ); }
		public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateFromAxisAngle(Vector3 axis, float angle) { throw new NotImplementedException( ); }
		public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateFromQuaternion(Quaternion quaternion) { throw new NotImplementedException( ); }
		public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll) { throw new NotImplementedException( ); }
		public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector) { throw new NotImplementedException( ); }
		public static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane) { throw new NotImplementedException( ); }
		public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane) { throw new NotImplementedException( ); }
		public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance) { throw new NotImplementedException( ); }
		public static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance) { throw new NotImplementedException( ); }
		public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance) { throw new NotImplementedException( ); }
		public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateReflection(Plane value) { throw new NotImplementedException( ); }
		public static void CreateReflection(ref Plane value, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateRotationX(float radians) { throw new NotImplementedException( ); }
		public static void CreateRotationX(float radians, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateRotationY(float radians) { throw new NotImplementedException( ); }
		public static void CreateRotationY(float radians, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateRotationZ(float radians) { throw new NotImplementedException( ); }
		public static void CreateRotationZ(float radians, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateScale(float scale) { throw new NotImplementedException( ); }
		public static void CreateScale(float scale, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateScale(float xScale, float yScale, float zScale) { throw new NotImplementedException( ); }
		public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateScale(Vector3 scales) { throw new NotImplementedException( ); }
		public static void CreateScale(ref Vector3 scales, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateShadow(Vector3 lightDirection, Plane plane) { throw new NotImplementedException( ); }
		public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition) { throw new NotImplementedException( ); }
		public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateTranslation(Vector3 position) { throw new NotImplementedException( ); }
		public static void CreateTranslation(ref Vector3 position, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up) { throw new NotImplementedException( ); }
		public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result) { throw new NotImplementedException( ); }
		public bool Decompose(out Vector3 scale, out Quaternion rotation, out Vector3 translation) { throw new NotImplementedException( ); }
		public float Determinant( ) { throw new NotImplementedException( ); }
		public static Matrix Divide(Matrix matrix1, float divider) { throw new NotImplementedException( ); }
		public static Matrix Divide(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static void Divide(ref Matrix matrix1, float divider, out Matrix result) { throw new NotImplementedException( ); }
		public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException( ); }
		public bool Equals(Matrix other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public static Matrix Invert(Matrix matrix) { throw new NotImplementedException( ); }
		public static void Invert(ref Matrix matrix, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount) { throw new NotImplementedException( ); }
		public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix Multiply(Matrix matrix1, float scaleFactor) { throw new NotImplementedException( ); }
		public static Matrix Multiply(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static void Multiply(ref Matrix matrix1, float scaleFactor, out Matrix result) { throw new NotImplementedException( ); }
		public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix Negate(Matrix matrix) { throw new NotImplementedException( ); }
		public static void Negate(ref Matrix matrix, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix Subtract(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static Matrix Transform(Matrix value, Quaternion rotation) { throw new NotImplementedException( ); }
		public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result) { throw new NotImplementedException( ); }
		public static Matrix Transpose(Matrix matrix) { throw new NotImplementedException( ); }
		public static void Transpose(ref Matrix matrix, out Matrix result) { throw new NotImplementedException( ); }

		public static bool operator !=(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static bool operator ==(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static Matrix operator +(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static Matrix operator -(Matrix matrix1) { throw new NotImplementedException( ); }
		public static Matrix operator -(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static Matrix operator *(float scaleFactor, Matrix matrix) { throw new NotImplementedException( ); }
		public static Matrix operator *(Matrix matrix, float scaleFactor) { throw new NotImplementedException( ); }
		public static Matrix operator *(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }
		public static Matrix operator /(Matrix matrix1, float divider) { throw new NotImplementedException( ); }
		public static Matrix operator /(Matrix matrix1, Matrix matrix2) { throw new NotImplementedException( ); }

		public Vector3 Backward { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 Down { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 Forward { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public static Matrix Identity { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 Left { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 Right { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 Translation { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 Up { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
