using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insma.Mxa.Framework.Graphics.PackedVector;

namespace Insma.Mxa.Framework {
	public struct Color : IPackedVector<uint>, IPackedVector, IEquatable<Color> {
		public Color(int r, int g, int b) { throw new NotImplementedException( ); }
		public Color(int r, int g, int b, int a) { throw new NotImplementedException( ); }
		public Color(float r, float g, float b) { throw new NotImplementedException( ); }
		public Color(float r, float g, float b, float a) { throw new NotImplementedException( ); }
		public Color(Vector3 vector) { throw new NotImplementedException( ); }
		public Color(Vector4 vector) { throw new NotImplementedException( ); }

		public bool Equals(Color other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) {throw new NotImplementedException(); }
		public override int GetHashCode( ) { throw new NotImplementedException();}
		public Vector3 ToVector3( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException();}
		public static bool operator !=(Color a, Color b) { throw new NotImplementedException( ); }
		public static bool operator ==(Color a, Color b) {throw new NotImplementedException(); }

		public uint PackedValue { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		void IPackedVector.PackFromVector4(Vector4 vector) { throw new NotImplementedException( ); }
		public Vector4 ToVector4( ) { throw new NotImplementedException( ); }

		public static Color FromNonPremultiplied(int r, int g, int b, int a) { throw new NotImplementedException( ); }
		public static Color FromNonPremultiplied(Vector4 vector) { throw new NotImplementedException( ); }
		public static Color Lerp(Color value1, Color value2, float amount) { throw new NotImplementedException( ); }
		public static Color Multiply(Color value, float scale) { throw new NotImplementedException( ); }
		public static Color operator *(Color value, float scale) { throw new NotImplementedException( ); }

		public byte A { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public byte B { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public byte G { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public byte R { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		public static Color AliceBlue { get { throw new NotImplementedException( ); } }
		public static Color AntiqueWhite { get { throw new NotImplementedException( ); } }
		public static Color Aqua { get { throw new NotImplementedException( ); } }
		public static Color Aquamarine { get { throw new NotImplementedException( ); } }
		public static Color Azure { get { throw new NotImplementedException( ); } }
		public static Color Beige { get { throw new NotImplementedException( ); } }
		public static Color Bisque { get { throw new NotImplementedException( ); } }
		public static Color Black { get { throw new NotImplementedException( ); } }
		public static Color BlanchedAlmond { get { throw new NotImplementedException( ); } }
		public static Color Blue { get { throw new NotImplementedException( ); } }
		public static Color BlueViolet { get { throw new NotImplementedException( ); } }
		public static Color Brown { get { throw new NotImplementedException( ); } }
		public static Color BurlyWood { get { throw new NotImplementedException( ); } }
		public static Color CadetBlue { get { throw new NotImplementedException( ); } }
		public static Color Chartreuse { get { throw new NotImplementedException( ); } }
		public static Color Chocolate { get { throw new NotImplementedException( ); } }
		public static Color Coral { get { throw new NotImplementedException( ); } }
		public static Color CornflowerBlue { get { throw new NotImplementedException( ); } }
		public static Color Cornsilk { get { throw new NotImplementedException( ); } }
		public static Color Crimson { get { throw new NotImplementedException( ); } }
		public static Color Cyan { get { throw new NotImplementedException( ); } }
		public static Color DarkBlue { get { throw new NotImplementedException( ); } }
		public static Color DarkCyan { get { throw new NotImplementedException( ); } }
		public static Color DarkGoldenrod { get { throw new NotImplementedException( ); } }
		public static Color DarkGray { get { throw new NotImplementedException( ); } }
		public static Color DarkGreen { get { throw new NotImplementedException( ); } }
		public static Color DarkKhaki { get { throw new NotImplementedException( ); } }
		public static Color DarkMagenta { get { throw new NotImplementedException( ); } }
		public static Color DarkOliveGreen { get { throw new NotImplementedException( ); } }
		public static Color DarkOrange { get { throw new NotImplementedException( ); } }
		public static Color DarkOrchid { get { throw new NotImplementedException( ); } }
		public static Color DarkRed { get { throw new NotImplementedException( ); } }
		public static Color DarkSalmon { get { throw new NotImplementedException( ); } }
		public static Color DarkSeaGreen { get { throw new NotImplementedException( ); } }
		public static Color DarkSlateBlue { get { throw new NotImplementedException( ); } }
		public static Color DarkSlateGray { get { throw new NotImplementedException( ); } }
		public static Color DarkTurquoise { get { throw new NotImplementedException( ); } }
		public static Color DarkViolet { get { throw new NotImplementedException( ); } }
		public static Color DeepPink { get { throw new NotImplementedException( ); } }
		public static Color DeepSkyBlue { get { throw new NotImplementedException( ); } }
		public static Color DimGray { get { throw new NotImplementedException( ); } }
		public static Color DodgerBlue { get { throw new NotImplementedException( ); } }
		public static Color Firebrick { get { throw new NotImplementedException( ); } }
		public static Color FloralWhite { get { throw new NotImplementedException( ); } }
		public static Color ForestGreen { get { throw new NotImplementedException( ); } }
		public static Color Fuchsia { get { throw new NotImplementedException( ); } }
		public static Color Gainsboro { get { throw new NotImplementedException( ); } }
		public static Color GhostWhite { get { throw new NotImplementedException( ); } }
		public static Color Gold { get { throw new NotImplementedException( ); } }
		public static Color Goldenrod { get { throw new NotImplementedException( ); } }
		public static Color Gray { get { throw new NotImplementedException( ); } }
		public static Color Green { get { throw new NotImplementedException( ); } }
		public static Color GreenYellow { get { throw new NotImplementedException( ); } }
		public static Color Honeydew { get { throw new NotImplementedException( ); } }
		public static Color HotPink { get { throw new NotImplementedException( ); } }
		public static Color IndianRed { get { throw new NotImplementedException( ); } }
		public static Color Indigo { get { throw new NotImplementedException( ); } }
		public static Color Ivory { get { throw new NotImplementedException( ); } }
		public static Color Khaki { get { throw new NotImplementedException( ); } }
		public static Color Lavender { get { throw new NotImplementedException( ); } }
		public static Color LavenderBlush { get { throw new NotImplementedException( ); } }
		public static Color LawnGreen { get { throw new NotImplementedException( ); } }
		public static Color LemonChiffon { get { throw new NotImplementedException( ); } }
		public static Color LightBlue { get { throw new NotImplementedException( ); } }
		public static Color LightCoral { get { throw new NotImplementedException( ); } }
		public static Color LightCyan { get { throw new NotImplementedException( ); } }
		public static Color LightGoldenrodYellow { get { throw new NotImplementedException( ); } }
		public static Color LightGray { get { throw new NotImplementedException( ); } }
		public static Color LightGreen { get { throw new NotImplementedException( ); } }
		public static Color LightPink { get { throw new NotImplementedException( ); } }
		public static Color LightSalmon { get { throw new NotImplementedException( ); } }
		public static Color LightSeaGreen { get { throw new NotImplementedException( ); } }
		public static Color LightSkyBlue { get { throw new NotImplementedException( ); } }
		public static Color LightSlateGray { get { throw new NotImplementedException( ); } }
		public static Color LightSteelBlue { get { throw new NotImplementedException( ); } }
		public static Color LightYellow { get { throw new NotImplementedException( ); } }
		public static Color Lime { get { throw new NotImplementedException( ); } }
		public static Color LimeGreen { get { throw new NotImplementedException( ); } }
		public static Color Linen { get { throw new NotImplementedException( ); } }
		public static Color Magenta { get { throw new NotImplementedException( ); } }
		public static Color Maroon { get { throw new NotImplementedException( ); } }
		public static Color MediumAquamarine { get { throw new NotImplementedException( ); } }
		public static Color MediumBlue { get { throw new NotImplementedException( ); } }
		public static Color MediumOrchid { get { throw new NotImplementedException( ); } }
		public static Color MediumPurple { get { throw new NotImplementedException( ); } }
		public static Color MediumSeaGreen { get { throw new NotImplementedException( ); } }
		public static Color MediumSlateBlue { get { throw new NotImplementedException( ); } }
		public static Color MediumSpringGreen { get { throw new NotImplementedException( ); } }
		public static Color MediumTurquoise { get { throw new NotImplementedException( ); } }
		public static Color MediumVioletRed { get { throw new NotImplementedException( ); } }
		public static Color MidnightBlue { get { throw new NotImplementedException( ); } }
		public static Color MintCream { get { throw new NotImplementedException( ); } }
		public static Color MistyRose { get { throw new NotImplementedException( ); } }
		public static Color Moccasin { get { throw new NotImplementedException( ); } }
		public static Color NavajoWhite { get { throw new NotImplementedException( ); } }
		public static Color Navy { get { throw new NotImplementedException( ); } }
		public static Color OldLace { get { throw new NotImplementedException( ); } }
		public static Color Olive { get { throw new NotImplementedException( ); } }
		public static Color OliveDrab { get { throw new NotImplementedException( ); } }
		public static Color Orange { get { throw new NotImplementedException( ); } }
		public static Color OrangeRed { get { throw new NotImplementedException( ); } }
		public static Color Orchid { get { throw new NotImplementedException( ); } }
		public static Color PaleGoldenrod { get { throw new NotImplementedException( ); } }
		public static Color PaleGreen { get { throw new NotImplementedException( ); } }
		public static Color PaleTurquoise { get { throw new NotImplementedException( ); } }
		public static Color PaleVioletRed { get { throw new NotImplementedException( ); } }
		public static Color PapayaWhip { get { throw new NotImplementedException( ); } }
		public static Color PeachPuff { get { throw new NotImplementedException( ); } }
		public static Color Peru { get { throw new NotImplementedException( ); } }
		public static Color Pink { get { throw new NotImplementedException( ); } }
		public static Color Plum { get { throw new NotImplementedException( ); } }
		public static Color PowderBlue { get { throw new NotImplementedException( ); } }
		public static Color Purple { get { throw new NotImplementedException( ); } }
		public static Color Red { get { throw new NotImplementedException( ); } }
		public static Color RosyBrown { get { throw new NotImplementedException( ); } }
		public static Color RoyalBlue { get { throw new NotImplementedException( ); } }
		public static Color SaddleBrown { get { throw new NotImplementedException( ); } }
		public static Color Salmon { get { throw new NotImplementedException( ); } }
		public static Color SandyBrown { get { throw new NotImplementedException( ); } }
		public static Color SeaGreen { get { throw new NotImplementedException( ); } }
		public static Color SeaShell { get { throw new NotImplementedException( ); } }
		public static Color Sienna { get { throw new NotImplementedException( ); } }
		public static Color Silver { get { throw new NotImplementedException( ); } }
		public static Color SkyBlue { get { throw new NotImplementedException( ); } }
		public static Color SlateBlue { get { throw new NotImplementedException( ); } }
		public static Color SlateGray { get { throw new NotImplementedException( ); } }
		public static Color Snow { get { throw new NotImplementedException( ); } }
		public static Color SpringGreen { get { throw new NotImplementedException( ); } }
		public static Color SteelBlue { get { throw new NotImplementedException( ); } }
		public static Color Tan { get { throw new NotImplementedException( ); } }
		public static Color Teal { get { throw new NotImplementedException( ); } }
		public static Color Thistle { get { throw new NotImplementedException( ); } }
		public static Color Tomato { get { throw new NotImplementedException( ); } }
		public static Color Transparent { get { throw new NotImplementedException( ); } }
		public static Color Turquoise { get { throw new NotImplementedException( ); } }
		public static Color Violet { get { throw new NotImplementedException( ); } }
		public static Color Wheat { get { throw new NotImplementedException( ); } }
		public static Color White { get { throw new NotImplementedException( ); } }
		public static Color WhiteSmoke { get { throw new NotImplementedException( ); } }
		public static Color Yellow { get { throw new NotImplementedException( ); } }
		public static Color YellowGreen { get { throw new NotImplementedException( ); } }
	}
}
