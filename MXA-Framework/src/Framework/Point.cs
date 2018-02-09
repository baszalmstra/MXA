using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public struct Point : IEquatable<Point> {
		public int X;
		public int Y;

		public Point(int x, int y) { this.X = x; this.Y = y; }
		public bool Equals(Point other) { throw new NotImplementedException( ); }
		public override bool Equals(object obj) { throw new NotImplementedException( ); }
		public override int GetHashCode( ) { throw new NotImplementedException( ); }
		public override string ToString( ) { throw new NotImplementedException( ); }
		public static bool operator !=(Point a, Point b) { throw new NotImplementedException( ); }
		public static bool operator ==(Point a, Point b) { throw new NotImplementedException( ); }
		public static Point Zero { get { throw new NotImplementedException( ); } }
	}
}
