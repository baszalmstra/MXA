﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class ContentSerializerRuntimeTypeAttribute : Attribute {
	}
}
