using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public interface IUpdateable {
		void Update(GameTime gameTime);
		bool Enabled { get; }
		int UpdateOrder { get; }
		event EventHandler<EventArgs> EnabledChanged;
		event EventHandler<EventArgs> UpdateOrderChanged;
	}
}
