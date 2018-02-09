using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	public class ResourceContentManager : ContentManager {
		public ResourceContentManager(IServiceProvider serviceProvider, ResourceManager resourceManager) : base(serviceProvider) { throw new NotImplementedException( ); }

		protected override Stream OpenStream(string assetName) { throw new NotImplementedException( ); }
	}
}
