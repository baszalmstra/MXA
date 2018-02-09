using System;

namespace Insma.Mxa.Framework.Media {
	[Flags]
	public enum VideoSoundtrackType : byte {
		Music = 1,
		Dialog = 2,
		MusicAndDialog = 3,
	}
}
