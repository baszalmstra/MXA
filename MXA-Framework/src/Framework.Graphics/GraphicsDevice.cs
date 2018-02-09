using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class GraphicsDevice : IDisposable {
		public GraphicsDevice(GraphicsAdapter adapter, GraphicsProfile graphicsProfile, PresentationParameters presentationParameters) { throw new NotImplementedException( ); }

		public void Clear(Color color) { throw new NotImplementedException( ); }
		public void Clear(ClearOptions options, Color color, float depth, int stencil) { throw new NotImplementedException( ); }
		public void Clear(ClearOptions options, Vector4 color, float depth, int stencil) { throw new NotImplementedException( ); }
		public void Dispose( ) { throw new NotImplementedException( ); }
		protected virtual void Dispose(bool p1) { throw new NotImplementedException( ); }
		public void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount) { throw new NotImplementedException( ); }
		public void DrawInstancedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount, int instanceCount) { throw new NotImplementedException( ); }
		public void DrawPrimitives(PrimitiveType primitiveType, int startVertex, int primitiveCount) { throw new NotImplementedException( ); }
		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType { throw new NotImplementedException( ); }
		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct { throw new NotImplementedException( ); }
		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType { throw new NotImplementedException( ); }
		public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct { throw new NotImplementedException( ); }
		public void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount) where T : struct, IVertexType { throw new NotImplementedException( ); }
		public void DrawUserPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct { throw new NotImplementedException( ); }
		public void GetBackBufferData<T>(Rectangle? rect, T[] data, int startIndex, int elementCount) where T : struct { throw new NotImplementedException( ); }
		public void GetBackBufferData<T>(T[] data) where T : struct { throw new NotImplementedException( ); }
		public void GetBackBufferData<T>(T[] data, int startIndex, int elementCount) where T : struct { throw new NotImplementedException( ); }
		public RenderTargetBinding[] GetRenderTargets( ) { throw new NotImplementedException( ); }
		public VertexBufferBinding[] GetVertexBuffers( ) { throw new NotImplementedException( ); }
		public void Present( ) { throw new NotImplementedException( ); }
		public void Present(Rectangle? sourceRectangle, Rectangle? destinationRectangle, IntPtr overrideWindowHandle) { throw new NotImplementedException( ); }
		protected void raise_DeviceLost(object sender, EventArgs eventArgs) { throw new NotImplementedException( ); }
		protected void raise_DeviceReset(object sender, EventArgs eventArgs) { throw new NotImplementedException( ); }
		protected void raise_DeviceResetting(object sender, EventArgs eventArgs) { throw new NotImplementedException( ); }
		protected void raise_Disposing(object sender, EventArgs eventArgs) { throw new NotImplementedException( ); }
		protected void raise_ResourceCreated(object sender, ResourceCreatedEventArgs resourceCreatedEventArgs) { throw new NotImplementedException( ); }
		protected void raise_ResourceDestroyed(object sender, ResourceDestroyedEventArgs resourceCreatedEventArgs) { throw new NotImplementedException( ); }
		public void Reset( ) { throw new NotImplementedException( ); }
		public void Reset(PresentationParameters presentationParameters) { throw new NotImplementedException( ); }
		public void Reset(PresentationParameters presentationParameters, GraphicsAdapter graphicsAdapter) { throw new NotImplementedException( ); }
		public void SetRenderTarget(RenderTarget2D renderTarget) { throw new NotImplementedException( ); }
		public void SetRenderTarget(RenderTargetCube renderTarget, CubeMapFace cubeMapFace) { throw new NotImplementedException( ); }
		public void SetRenderTargets(params RenderTargetBinding[] renderTargets) { throw new NotImplementedException( ); }
		public void SetVertexBuffer(VertexBuffer vertexBuffer) { throw new NotImplementedException( ); }
		public void SetVertexBuffer(VertexBuffer vertexBuffer, int vertexOffset) { throw new NotImplementedException( ); }
		public void SetVertexBuffers(params VertexBufferBinding[] vertexBuffers) { throw new NotImplementedException( ); }

		public GraphicsAdapter Adapter { get { throw new NotImplementedException( ); } }
		public Color BlendFactor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public BlendState BlendState { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public DepthStencilState DepthStencilState { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public DisplayMode DisplayMode { get { throw new NotImplementedException( ); } }
		public GraphicsDeviceStatus GraphicsDeviceStatus { get { throw new NotImplementedException( ); } }
		public GraphicsProfile GraphicsProfile { get { throw new NotImplementedException( ); } }
		public IndexBuffer Indices { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool IsDisposed { get { throw new NotImplementedException( ); } }
		public int MultiSampleMask { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public PresentationParameters PresentationParameters { get { throw new NotImplementedException( ); } }
		public RasterizerState RasterizerState { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int ReferenceStencil { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public SamplerStateCollection SamplerStates { get { throw new NotImplementedException( ); } }
		public Rectangle ScissorRectangle { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public TextureCollection Textures { get { throw new NotImplementedException( ); } }
		public SamplerStateCollection VertexSamplerStates { get { throw new NotImplementedException( ); } }
		public TextureCollection VertexTextures { get { throw new NotImplementedException( ); } }
		public Viewport Viewport { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }

		public event EventHandler<EventArgs> DeviceLost;
		public event EventHandler<EventArgs> DeviceReset;
		public event EventHandler<EventArgs> DeviceResetting;
		public event EventHandler<EventArgs> Disposing;
		public event EventHandler<EventArgs> DrawGuide;
		public event EventHandler<ResourceCreatedEventArgs> ResourceCreated;
		public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;
	}
}
