using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public class Curve {
		public Curve( ) { throw new NotImplementedException( ); }
		public Curve Clone( ) { throw new NotImplementedException( ); }
		public void ComputeTangent(int keyIndex, CurveTangent tangentType) { throw new NotImplementedException( ); }
		public void ComputeTangent(int keyIndex, CurveTangent tangentInType, CurveTangent tangentOutType) { throw new NotImplementedException( ); }
		public void ComputeTangents(CurveTangent tangentType) { throw new NotImplementedException( ); }
		public void ComputeTangents(CurveTangent tangentInType, CurveTangent tangentOutType) { throw new NotImplementedException( ); }
		public float Evaluate(float position) { throw new NotImplementedException( ); }
		public bool IsConstant { get { throw new NotImplementedException( ); } }
		public CurveKeyCollection Keys { get { throw new NotImplementedException( ); } }
		public CurveLoopType PostLoop { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public CurveLoopType PreLoop { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
