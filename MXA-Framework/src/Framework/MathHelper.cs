using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public static class MathHelper {
		public const float E = 2.71828f;
		public const float Log10E = 0.434294f;
		public const float Log2E = 1.4427f;
		public const float Pi = 3.14159f;
		public const float PiOver2 = 1.5708f;
		public const float PiOver4 = 0.785398f;
		public const float TwoPi = 6.28319f;

		public static float Barycentric(float value1, float value2, float value3, float amount1, float amount2) { throw new NotImplementedException( ); }
		public static float CatmullRom(float value1, float value2, float value3, float value4, float amount) { throw new NotImplementedException( ); }
		public static float Clamp(float value, float min, float max) { throw new NotImplementedException( ); }
		public static float Distance(float value1, float value2) { throw new NotImplementedException( ); }
		public static float Hermite(float value1, float tangent1, float value2, float tangent2, float amount) { throw new NotImplementedException( ); }
		public static float Lerp(float value1, float value2, float amount) { throw new NotImplementedException( ); }
		public static float Max(float value1, float value2) { throw new NotImplementedException( ); }
		public static float Min(float value1, float value2) { throw new NotImplementedException( ); }
		public static float SmoothStep(float value1, float value2, float amount) { throw new NotImplementedException( ); }
		public static float ToDegrees(float radians) { throw new NotImplementedException( ); }
		public static float ToRadians(float degrees) { throw new NotImplementedException( ); }
		public static float WrapAngle(float angle) { throw new NotImplementedException( ); }
	}
}
