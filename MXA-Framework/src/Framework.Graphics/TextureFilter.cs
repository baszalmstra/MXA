using System;

namespace Insma.Mxa.Framework.Graphics {
	public enum TextureFilter {
		Linear = 0,
		Point = 1,
		Anisotropic = 2,
		LinearMipPoint = 3,
		PointMipLinear = 4,
		MinLinearMagPointMipLinear = 5,
		MinLinearMagPointMipPoint = 6,
		MinPointMagLinearMipLinear = 7,
		MinPointMagLinearMipPoint = 8,
	}
}
