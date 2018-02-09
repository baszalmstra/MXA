using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Content {
	public sealed class ContentReader : BinaryReader {
		internal ContentReader(Stream input) : base(input) { throw new NotImplementedException( ); }
		internal ContentReader(Stream input, Encoding encoding) : base(input, encoding) { throw new NotImplementedException( ); }
		internal ContentReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen) { throw new NotImplementedException( ); }

		public override float ReadSingle( ) { throw new NotImplementedException( ); }
		public override double ReadDouble( ) { throw new NotImplementedException( ); }
		public Color ReadColor( ) { throw new NotImplementedException( ); }
		public Matrix ReadMatrix( ) { throw new NotImplementedException( ); }
		public Quaternion ReadQuaternion( ) { throw new NotImplementedException( ); }
		public Vector2 ReadVector2( ) { throw new NotImplementedException( ); }
		public Vector3 ReadVector3( ) { throw new NotImplementedException( ); }
		public Vector4 ReadVector4( ) { throw new NotImplementedException( ); }

		public T ReadExternalReference<T>( ) { throw new NotImplementedException( ); }
		public void ReadSharedResource<T>(Action<T> fixup) { throw new NotImplementedException( ); }
		public T ReadObject<T>( ) { throw new NotImplementedException( ); }
		public T ReadObject<T>(ContentTypeReader typeReader) { throw new NotImplementedException( ); }
		public T ReadObject<T>(ContentTypeReader typeReader, T existingInstance) { throw new NotImplementedException( ); }
		public T ReadObject<T>(T existingInstance) { throw new NotImplementedException( ); }
		public T ReadRawObject<T>( ) { throw new NotImplementedException( ); }
		public T ReadRawObject<T>(ContentTypeReader typeReader) { throw new NotImplementedException( ); }
		public T ReadRawObject<T>(ContentTypeReader typeReader, T existingInstance) { throw new NotImplementedException( ); }
		public T ReadRawObject<T>(T existingInstance) { throw new NotImplementedException( ); }

		public string AssetName { get { throw new NotImplementedException( ); } }
		public ContentManager ContentManager { get { throw new NotImplementedException( ); } }
	}
}
