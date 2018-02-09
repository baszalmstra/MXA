using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public class GameComponentCollectionEventArgs : EventArgs {
		public GameComponentCollectionEventArgs(IGameComponent gameComponent) { throw new NotImplementedException( ); }

		public IGameComponent GameComponent { get { throw new NotImplementedException( ); } }
	}
}
