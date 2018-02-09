using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	public class ContentManager : IDisposable {
		public ContentManager(IServiceProvider serviceProvider) { throw new NotImplementedException( ); }
		public ContentManager(IServiceProvider serviceProvider, string rootDirectory) { throw new NotImplementedException( ); }
		public void Dispose( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool disposing) { throw new NotImplementedException( ); }
		public virtual T Load<T>(string assetName) { throw new NotImplementedException( ); }
		protected virtual Stream OpenStream(string assetName) { throw new NotImplementedException( ); }
		protected T ReadAsset<T>(string assetName, Action<IDisposable> recordDisposableObject) { throw new NotImplementedException( ); }
		public virtual void Unload( ) { throw new NotImplementedException( ); }

		public string RootDirectory { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public IServiceProvider ServiceProvider { get { throw new NotImplementedException( ); } }
	}
}
