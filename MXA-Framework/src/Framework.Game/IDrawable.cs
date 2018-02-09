using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework {
	public interface IDrawable {
		void Draw(GameTime gameTime);
		int DrawOrder { get; }
		bool Visible { get; }
		event EventHandler<EventArgs> DrawOrderChanged;
		event EventHandler<EventArgs> VisibleChanged;
	}
}
