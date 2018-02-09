using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public class GameComponent : IGameComponent, IUpdateable, IDisposable {
		public GameComponent(Game game) { throw new NotImplementedException( ); }

		public void Dispose( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool disposing) { throw new NotImplementedException( ); }
		public virtual void Initialize( ) { throw new NotImplementedException( ); }
		public virtual void Update(GameTime gameTime) { throw new NotImplementedException( ); }
		protected virtual void OnEnabledChanged(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnUpdateOrderChanged(object sender, EventArgs args) { throw new NotImplementedException( ); }

		public bool Enabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Game Game { get { throw new NotImplementedException( ); } }
		public int UpdateOrder { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> Disposed;
		public event EventHandler<EventArgs> EnabledChanged;
		public event EventHandler<EventArgs> UpdateOrderChanged;
	}
}
