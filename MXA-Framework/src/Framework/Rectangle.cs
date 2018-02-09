using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Rectangle : IEquatable<Rectangle> {
		public int Height;
		public int Width;
		public int X;
		public int Y;

		public Rectangle(int x, int y, int width, int height) { throw new NotImplementedException( ); }
		public bool Contains(int x, int y) { throw new NotImplementedException( ); }
		public bool Contains(Point value) { throw new NotImplementedException( ); }
		public bool Contains(Rectangle value) { throw new NotImplementedException( ); }
		public void Contains(ref Point value, out bool result) { throw new NotImplementedException( ); }
		public void Contains(ref Rectangle value, out bool result) { throw new NotImplementedException( ); }
		public bool Equals(Rectangle other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public void Inflate(int horizontalAmount, int verticalAmount) { throw new NotImplementedException( ); }
		public static Rectangle Intersect(Rectangle value1, Rectangle value2) { throw new NotImplementedException( ); }
		public static void Intersect(ref Rectangle value1, ref Rectangle value2, out Rectangle result) { throw new NotImplementedException( ); }
		public bool Intersects(Rectangle value) { throw new NotImplementedException( ); }
		public void Intersects(ref Rectangle value, out bool result) { throw new NotImplementedException( ); }
		public void Offset(int offsetX, int offsetY) { throw new NotImplementedException( ); }
		public void Offset(Point amount) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static Rectangle Union(Rectangle value1, Rectangle value2) { throw new NotImplementedException( ); }
		public static void Union(ref Rectangle value1, ref Rectangle value2, out Rectangle result) { throw new NotImplementedException( ); }
		public static bool operator !=(Rectangle a, Rectangle b) { throw new NotImplementedException( ); }
		public static bool operator ==(Rectangle a, Rectangle b) { throw new NotImplementedException( ); }
		public int Bottom { get { throw new NotImplementedException( ); } }
		public Point Center { get { throw new NotImplementedException( ); } }
		public static Rectangle Empty { get { throw new NotImplementedException( ); } }
		public bool IsEmpty { get { throw new NotImplementedException( ); } }
		public int Left { get { throw new NotImplementedException( ); } }
		public Point Location { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int Right { get { throw new NotImplementedException( ); } }
		public int Top { get { throw new NotImplementedException( ); } }
	}
}
