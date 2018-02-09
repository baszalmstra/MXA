using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insma.Mxa.Framework.Content;
using Insma.Mxa.Framework.Graphics;

namespace Insma.Mxa.Framework {
	public class Game : IDisposable {
		public Game( ) { throw new NotImplementedException( ); }

		public void Dispose( ) { throw new NotImplementedException( ); }
		public void Exit( ) { throw new NotImplementedException( ); }
		public void ResetElapsedTime( ) { throw new NotImplementedException( ); }
		public void Run( ) { throw new NotImplementedException( ); }
		public void RunOneFrame( ) { throw new NotImplementedException( ); }
		public void SuppressDraw( ) { throw new NotImplementedException( ); }
		public void Tick( ) { throw new NotImplementedException( ); }
		protected virtual bool BeginDraw( ) { throw new NotImplementedException( ); }
		protected virtual void BeginRun( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool disposing) { throw new NotImplementedException( ); }
		protected virtual void Draw(GameTime gameTime) { throw new NotImplementedException( ); }
		protected virtual void EndDraw( ) { throw new NotImplementedException( ); }
		protected virtual void EndRun( ) { throw new NotImplementedException( ); }
		protected virtual void Initialize( ) { throw new NotImplementedException( ); }
		protected virtual void LoadContent( ) { throw new NotImplementedException( ); }
		protected virtual bool ShowMissingRequirementMessage(Exception exception) { throw new NotImplementedException( ); }
		protected virtual void UnloadContent( ) { throw new NotImplementedException( ); }
		protected virtual void Update(GameTime gameTime) { throw new NotImplementedException( ); }
		protected virtual void OnActivated(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnDeactivated(object sender, EventArgs args) { throw new NotImplementedException( ); }
		protected virtual void OnExiting(object sender, EventArgs args) { throw new NotImplementedException( ); }

		public GameComponentCollection Components { get { throw new NotImplementedException( ); } }
		public ContentManager Content { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public GraphicsDevice GraphicsDevice { get { throw new NotImplementedException( ); } }
		public TimeSpan InactiveSleepTime { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool IsActive { get { throw new NotImplementedException( ); } }
		public bool IsFixedTimeStep { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool IsMouseVisible { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public LaunchParameters LaunchParameters { get { throw new NotImplementedException( ); } }
		public GameServiceContainer Services { get { throw new NotImplementedException( ); } }
		public TimeSpan TargetElapsedTime { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public GameWindow Window { get { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> Activated;
		public event EventHandler<EventArgs> Deactivated;
		public event EventHandler<EventArgs> Disposed;
		public event EventHandler<EventArgs> Exiting;
	}
}
