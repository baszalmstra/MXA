using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public class GameTime {
		public GameTime( ) { throw new NotImplementedException( ); }
		public GameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime) { throw new NotImplementedException( ); }
		public GameTime(TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly) { throw new NotImplementedException( ); }

		public TimeSpan ElapsedGameTime { get { throw new NotImplementedException( ); } internal set { throw new NotImplementedException( ); } }
		public bool IsRunningSlowly { get { throw new NotImplementedException( ); } internal set { throw new NotImplementedException( ); } }
		public TimeSpan TotalGameTime { get { throw new NotImplementedException( ); } internal set { throw new NotImplementedException( ); } }
	}
}
