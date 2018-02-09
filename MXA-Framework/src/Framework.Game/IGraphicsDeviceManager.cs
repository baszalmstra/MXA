using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public interface IGraphicsDeviceManager {
		bool BeginDraw( );
		void CreateDevice( );
		void EndDraw( );
	}
}
