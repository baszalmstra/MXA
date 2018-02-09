using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insma.Mxa.Framework.Graphics;

namespace Insma.Mxa.Framework {
	public class DrawableGameComponent : GameComponent, IDrawable {
		public DrawableGameComponent(Game game) : base(game) { throw new NotImplementedException( ); }

		protected override void Dispose(bool disposing) { throw new NotImplementedException( ); }
		public virtual void Draw(GameTime gameTime) { throw new NotImplementedException( ); }
		public override void Initialize( ) { throw new NotImplementedException( ); }
		protected virtual void LoadContent( ) { throw new NotImplementedException( ); }
		protected virtual void UnloadContent( ) { throw new NotImplementedException( ); }
		protected virtual void OnDrawOrderChanged(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnVisibleChanged(object sender, EventArgs args) { throw new NotImplementedException( ); }

		public int DrawOrder { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public GraphicsDevice GraphicsDevice { get { throw new NotImplementedException( ); } }
		public bool Visible { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> DrawOrderChanged;
		public event EventHandler<EventArgs> VisibleChanged;
	}
}
