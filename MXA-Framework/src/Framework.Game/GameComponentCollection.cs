using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public sealed class GameComponentCollection : Collection<IGameComponent> {
		public GameComponentCollection( ) { throw new NotImplementedException( ); }

		protected override void ClearItems( ) { throw new NotImplementedException( ); }
		protected override void InsertItem(int index, IGameComponent item) { throw new NotImplementedException( ); }
		protected override void RemoveItem(int index) { throw new NotImplementedException( ); }
		protected override void SetItem(int index, IGameComponent item) { throw new NotImplementedException( ); }

		public event System.EventHandler<GameComponentCollectionEventArgs> ComponentAdded;
		public event System.EventHandler<GameComponentCollectionEventArgs> ComponentRemoved;
	}
}
