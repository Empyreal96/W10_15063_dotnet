// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.GraphicsDevice
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class GraphicsDevice : IDisposable
  {
    internal const int MaximumPacketSize = 32768;
    internal const int DrawUserPrimitivePacketBufferThreshold = 1536;
    internal uint pComPtr = uint.MaxValue;
    internal PresentationParameters _internalCachedPresentParams;
    private PresentationParameters _publicCachedPresentParams;
    private Dictionary<uint, WeakReference> _knownResources;
    internal Rectangle _scissorRect;
    internal bool _scissorRectDirty = true;
    internal Viewport _viewport;
    private GraphicsAdapter _adapter;
    private GraphicsProfile _graphicsProfile;
    internal ProfileCapabilities _profileCapabilities;
    internal DeclarationManager vertexDeclarationManager;
    internal int currentRenderTargetCount;
    private RenderTargetHelper[] currentRenderTargets;
    private RenderTargetBinding[] currentRenderTargetBindings;
    private RenderTargetBinding[] tempRenderTarget;
    private int currentVertexBufferCount;
    private VertexBufferBinding[] currentVertexBuffers;
    private VertexBufferBinding[] tempVertexBuffer;
    private IndexBuffer _currentIB;
    internal bool _vertexShaderActive;
    internal bool _pixelShaderActive;
    private BlendState cachedBlendState;
    private Color cachedBlendFactor;
    private int cachedMultiSampleMask;
    private bool blendStateDirty;
    private DepthStencilState cachedDepthStencilState;
    private int cachedReferenceStencil;
    private bool depthStencilStateDirty;
    private RasterizerState cachedRasterizerState;
    internal byte[] currentPacket;
    internal uint currentPacketSize;
    internal static object packetSyncObject = new object();
    private TextureCollection _textures;
    private TextureCollection _vertexTextures;
    private SamplerStateCollection _samplerStates;
    private SamplerStateCollection _vertexSamplerStates;
    internal ushort spriteBeginCount;
    internal ushort spriteImmediateBeginCount;
    internal bool supportsDirectRendering;
    internal bool inDirectRenderingMode;
    private bool _isDisposed;

    public event EventHandler<EventArgs> DeviceLost;

    public event EventHandler<EventArgs> DeviceReset;

    public event EventHandler<EventArgs> DeviceResetting;

    public event EventHandler<ResourceCreatedEventArgs> ResourceCreated;

    public event EventHandler<ResourceDestroyedEventArgs> ResourceDestroyed;

    public PresentationParameters PresentationParameters => this._publicCachedPresentParams;

    public GraphicsAdapter Adapter => this._adapter;

    public GraphicsProfile GraphicsProfile => this._graphicsProfile;

    public GraphicsDeviceStatus GraphicsDeviceStatus => GraphicsDeviceStatus.Normal;

    public DisplayMode DisplayMode => this._adapter.CurrentDisplayMode;

    public TextureCollection Textures => this._textures;

    public TextureCollection VertexTextures => this._vertexTextures;

    public SamplerStateCollection SamplerStates => this._samplerStates;

    public SamplerStateCollection VertexSamplerStates => this._vertexSamplerStates;

    internal GraphicsDevice(
      GraphicsAdapter adapter,
      GraphicsProfile graphicsProfile,
      PresentationParameters presentationParameters,
      bool supportsDirectRendering)
    {
      this.Initialize(adapter, graphicsProfile, presentationParameters, supportsDirectRendering);
    }

    public GraphicsDevice(
      GraphicsAdapter adapter,
      GraphicsProfile graphicsProfile,
      PresentationParameters presentationParameters)
    {
      this.Initialize(adapter, graphicsProfile, presentationParameters, false);
    }

    [SecuritySafeCritical]
    private void Initialize(
      GraphicsAdapter adapter,
      GraphicsProfile graphicsProfile,
      PresentationParameters presentationParameters,
      bool supportsDirectRendering)
    {
      if (adapter == null)
        throw new ArgumentNullException(nameof (adapter), FrameworkResources.NullNotAllowed);
      if (presentationParameters == null)
        throw new ArgumentNullException(nameof (presentationParameters), FrameworkResources.NullNotAllowed);
      this._adapter = adapter;
      this._graphicsProfile = graphicsProfile;
      this._profileCapabilities = ProfileCapabilities.GetInstance(graphicsProfile);
      this.supportsDirectRendering = supportsDirectRendering;
      if (!adapter.IsProfileSupported(graphicsProfile))
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileInvalidDevice);
      this.ValidatePresentationParameters(presentationParameters);
      this.pComPtr = UnsafeNativeMethods.Adapter.CreateDevice(GraphicsAdapter.pComHandle, ref presentationParameters.settings, graphicsProfile);
      if (this.pComPtr == uint.MaxValue)
        throw new NotSupportedException();
      this.currentPacket = new byte[32768];
      this._textures = new TextureCollection(this, 0, this._profileCapabilities.MaxSamplers);
      this._vertexTextures = new TextureCollection(this, this._profileCapabilities.MaxSamplers, this._profileCapabilities.MaxVertexSamplers);
      this._samplerStates = new SamplerStateCollection(this, 0, this._profileCapabilities.MaxSamplers);
      this._vertexSamplerStates = new SamplerStateCollection(this, this._profileCapabilities.MaxSamplers, this._profileCapabilities.MaxVertexSamplers);
      this.currentVertexBuffers = new VertexBufferBinding[this._profileCapabilities.MaxVertexStreams];
      this.tempVertexBuffer = new VertexBufferBinding[1];
      this.vertexDeclarationManager = new DeclarationManager(this);
      this._internalCachedPresentParams = presentationParameters.Clone();
      this._publicCachedPresentParams = presentationParameters.Clone();
      this._viewport = new Viewport();
      this._viewport.Width = presentationParameters.BackBufferWidth;
      this._viewport.Height = presentationParameters.BackBufferHeight;
      this._viewport.MaxDepth = 1f;
      this._knownResources = new Dictionary<uint, WeakReference>();
      this.currentRenderTargets = new RenderTargetHelper[this._profileCapabilities.MaxRenderTargets];
      this.currentRenderTargetBindings = new RenderTargetBinding[this._profileCapabilities.MaxRenderTargets];
      this.tempRenderTarget = new RenderTargetBinding[1];
      if (supportsDirectRendering)
        return;
      this.InitializeDeviceState();
    }

    private void ValidatePresentationParameters(PresentationParameters presentationParameters)
    {
      if (presentationParameters.DeviceWindowHandle == IntPtr.Zero)
        throw new ArgumentException(FrameworkResources.NullWindowHandleNotAllowed);
      Helpers.ValidateOrientation(presentationParameters.DisplayOrientation);
      SurfaceFormat selectedFormat;
      DepthFormat selectedDepthFormat;
      int selectedMultiSampleCount;
      this._adapter.QueryBackBufferFormat(this._graphicsProfile, presentationParameters.BackBufferFormat, presentationParameters.DepthStencilFormat, presentationParameters.MultiSampleCount, out selectedFormat, out selectedDepthFormat, out selectedMultiSampleCount);
      presentationParameters.BackBufferFormat = selectedFormat;
      presentationParameters.DepthStencilFormat = selectedDepthFormat;
      presentationParameters.MultiSampleCount = selectedMultiSampleCount;
      DisplayMode currentDisplayMode = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode;
      if (presentationParameters.BackBufferWidth <= 0 || presentationParameters.BackBufferHeight <= 0)
      {
        if (Helpers.IsLandscape(presentationParameters.DisplayOrientation))
        {
          presentationParameters.BackBufferWidth = currentDisplayMode.Height;
          presentationParameters.BackBufferHeight = currentDisplayMode.Width;
        }
        else
        {
          presentationParameters.BackBufferWidth = currentDisplayMode.Width;
          presentationParameters.BackBufferHeight = currentDisplayMode.Height;
        }
      }
      if (presentationParameters.BackBufferWidth > this._profileCapabilities.MaxTextureSize || presentationParameters.BackBufferHeight > this._profileCapabilities.MaxTextureSize)
        throw new ArgumentException(FrameworkResources.BackBufferBadSize, nameof (presentationParameters));
      int width = presentationParameters.BackBufferWidth;
      int height = presentationParameters.BackBufferHeight;
      if (Helpers.IsLandscape(Helpers.ChooseOrientation(presentationParameters.DisplayOrientation, width, height, false)))
      {
        int num = width;
        width = height;
        height = num;
      }
      if (width < 240 || height < 240 || (width > Helpers.MaxDisplayWidth || height > Helpers.MaxDisplayHeight))
        throw new ArgumentException(FrameworkResources.BackBufferBadSize, nameof (presentationParameters));
    }

    internal void InitializeDeviceState()
    {
      this.cachedBlendState = (BlendState) null;
      this.cachedDepthStencilState = (DepthStencilState) null;
      this.cachedRasterizerState = (RasterizerState) null;
      this.BlendState = BlendState.Opaque;
      this.DepthStencilState = DepthStencilState.Default;
      this.RasterizerState = RasterizerState.CullCounterClockwise;
      this._samplerStates.InitializeDeviceState();
      this._vertexSamplerStates.InitializeDeviceState();
    }

    public void Clear(Color color)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
      Vector4 vector4 = color.ToVector4();
      PacketHelpers.AddClearPacket(this, this.DefaultClearOptions, ref vector4, 1f, 0);
    }

    public void Clear(ClearOptions options, Color color, float depth, int stencil) => this.Clear(options, color.ToVector4(), depth, stencil);

    public void Clear(ClearOptions options, Vector4 color, float depth, int stencil)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
      ClearOptions clearOptions = options & (ClearOptions.DepthBuffer | ClearOptions.Stencil);
      if ((clearOptions & this.DefaultClearOptions) != clearOptions)
        throw new InvalidOperationException(FrameworkResources.CannotClearNullDepth);
      PacketHelpers.AddClearPacket(this, options, ref color, depth, stencil);
    }

    [SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")]
    public IndexBuffer Indices
    {
      get => this._currentIB;
      set
      {
        if (value != null && value._isDisposed)
          throw new ObjectDisposedException(value.GetType().Name);
        if (value == this._currentIB)
          return;
        this._currentIB = value;
        PacketHelpers.SendResourceSetPacket(this, HLCBPacketType.SetIndexBuffer, value != null ? value.pComPtr : 0U);
      }
    }

    public Rectangle ScissorRectangle
    {
      get
      {
        if (this._scissorRectDirty)
        {
          GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Device.GetGlobal(this).GetScissorRect(this.pComPtr, out this._scissorRect));
          this._scissorRect.Width -= this._scissorRect.Left;
          this._scissorRect.Height -= this._scissorRect.Top;
          this._scissorRectDirty = false;
        }
        return this._scissorRect;
      }
      set
      {
        if (this._isDisposed)
          throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
        if (value.Left < 0 || value.Width < 0 || (value.Top < 0 || value.Height < 0))
          throw new ArgumentException(FrameworkResources.ScissorInvalid, nameof (value));
        int num1;
        int num2;
        if (this.currentRenderTargetCount > 0)
        {
          num1 = this.currentRenderTargets[0].width;
          num2 = this.currentRenderTargets[0].height;
        }
        else
        {
          num1 = this._internalCachedPresentParams.BackBufferWidth;
          num2 = this._internalCachedPresentParams.BackBufferHeight;
        }
        if (value.Left + value.Width > num1 || value.Top + value.Height > num2)
          throw new ArgumentException(FrameworkResources.ScissorInvalid, nameof (value));
        this._scissorRect = value;
        this._scissorRectDirty = false;
        PacketHelpers.SendScissorRect(this, ref this._scissorRect);
      }
    }

    public Viewport Viewport
    {
      get => this._viewport;
      set
      {
        if (this._isDisposed)
          throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
        if (value.X < 0 || value.Y < 0 || (value.Width <= 0 || value.Height <= 0))
          throw new ArgumentException(FrameworkResources.ViewportInvalid, nameof (value));
        int num1;
        int num2;
        if (this.currentRenderTargetCount > 0)
        {
          num1 = this.currentRenderTargets[0].width;
          num2 = this.currentRenderTargets[0].height;
        }
        else
        {
          num1 = this._internalCachedPresentParams.BackBufferWidth;
          num2 = this._internalCachedPresentParams.BackBufferHeight;
        }
        if (value.X + value.Width > num1 || value.Y + value.Height > num2)
          throw new ArgumentException(FrameworkResources.ViewportInvalid, nameof (value));
        if ((double) value.MinDepth < 0.0 || (double) value.MinDepth > 1.0)
          throw new ArgumentException(FrameworkResources.ViewportInvalid, nameof (value));
        if ((double) value.MaxDepth < 0.0 || (double) value.MaxDepth > 1.0)
          throw new ArgumentException(FrameworkResources.ViewportInvalid, nameof (value));
        if ((double) value.MaxDepth < (double) value.MinDepth)
          throw new ArgumentException(FrameworkResources.ViewportInvalid, nameof (value));
        this._viewport = value;
        PacketHelpers.SendViewPort(this, ref value);
      }
    }

    public VertexBufferBinding[] GetVertexBuffers()
    {
      VertexBufferBinding[] vertexBufferBindingArray = new VertexBufferBinding[this.currentVertexBufferCount];
      Array.Copy((Array) this.currentVertexBuffers, (Array) vertexBufferBindingArray, this.currentVertexBufferCount);
      return vertexBufferBindingArray;
    }

    public void SetVertexBuffer(VertexBuffer vertexBuffer)
    {
      if (vertexBuffer != null)
      {
        try
        {
          this.tempVertexBuffer[0] = new VertexBufferBinding(vertexBuffer);
          this.SetVertexBuffers(this.tempVertexBuffer);
        }
        finally
        {
          this.tempVertexBuffer[0]._vertexBuffer = (VertexBuffer) null;
        }
      }
      else
        this.SetVertexBuffers((VertexBufferBinding[]) null);
    }

    public void SetVertexBuffer(VertexBuffer vertexBuffer, int vertexOffset)
    {
      if (vertexBuffer != null)
      {
        try
        {
          this.tempVertexBuffer[0] = new VertexBufferBinding(vertexBuffer, vertexOffset);
          this.SetVertexBuffers(this.tempVertexBuffer);
        }
        finally
        {
          this.tempVertexBuffer[0]._vertexBuffer = (VertexBuffer) null;
        }
      }
      else
        this.SetVertexBuffers((VertexBufferBinding[]) null);
    }

    public void SetVertexBuffers(params VertexBufferBinding[] vertexBuffers)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
      int num = vertexBuffers != null ? vertexBuffers.Length : 0;
      if (num > this._profileCapabilities.MaxVertexStreams)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxVertexStreams, (object) this._profileCapabilities.MaxVertexStreams);
      int stream1 = 0;
      try
      {
        for (stream1 = 0; stream1 < num; ++stream1)
        {
          VertexBuffer vertexBuffer1 = vertexBuffers[stream1]._vertexBuffer;
          if (vertexBuffer1 == null)
            throw new ArgumentException(FrameworkResources.NullNotAllowed);
          if (vertexBuffer1._isDisposed)
            throw new ObjectDisposedException(vertexBuffer1.GetType().Name, FrameworkResources.ObjectDisposedException);
          if (vertexBuffer1.GraphicsDevice != this)
            throw new InvalidOperationException(FrameworkResources.InvalidDevice);
          VertexBuffer vertexBuffer2 = this.currentVertexBuffers[stream1]._vertexBuffer;
          int vertexOffset = vertexBuffers[stream1]._vertexOffset;
          int instanceFrequency = vertexBuffers[stream1]._instanceFrequency;
          if (vertexBuffer1 != vertexBuffer2 || vertexOffset != this.currentVertexBuffers[stream1]._vertexOffset || instanceFrequency != this.currentVertexBuffers[stream1]._instanceFrequency)
          {
            int vertexStride = vertexBuffer1._vertexDeclaration._vertexStride;
            PacketHelpers.AddSetStreamSource(this, stream1, vertexBuffer1.pComPtr, vertexOffset * vertexStride, vertexStride, instanceFrequency);
            this.currentVertexBuffers[stream1] = vertexBuffers[stream1];
          }
        }
      }
      finally
      {
        for (int stream2 = stream1; stream2 < this.currentVertexBufferCount; ++stream2)
        {
          PacketHelpers.AddSetStreamSource(this, stream2, 0U, 0, 0, 0);
          this.currentVertexBuffers[stream2] = new VertexBufferBinding();
        }
        this.currentVertexBufferCount = stream1;
      }
      if (num <= 0)
        return;
      this.vertexDeclarationManager.SetVertexDeclaration(vertexBuffers);
    }

    public RenderTargetBinding[] GetRenderTargets()
    {
      RenderTargetBinding[] renderTargetBindingArray = new RenderTargetBinding[this.currentRenderTargetCount];
      Array.Copy((Array) this.currentRenderTargetBindings, (Array) renderTargetBindingArray, this.currentRenderTargetCount);
      return renderTargetBindingArray;
    }

    public void SetRenderTarget(RenderTarget2D renderTarget)
    {
      if (renderTarget != null)
      {
        try
        {
          this.tempRenderTarget[0] = new RenderTargetBinding(renderTarget);
          this.SetRenderTargets(this.tempRenderTarget);
        }
        finally
        {
          this.tempRenderTarget[0]._renderTarget = (Texture) null;
        }
      }
      else
        this.SetRenderTargets((RenderTargetBinding[]) null);
    }

    public void SetRenderTarget(RenderTargetCube renderTarget, CubeMapFace cubeMapFace)
    {
      if (renderTarget != null)
      {
        try
        {
          this.tempRenderTarget[0] = new RenderTargetBinding(renderTarget, cubeMapFace);
          this.SetRenderTargets(this.tempRenderTarget);
        }
        finally
        {
          this.tempRenderTarget[0]._renderTarget = (Texture) null;
        }
      }
      else
        this.SetRenderTargets((RenderTargetBinding[]) null);
    }

    public void SetRenderTargets(params RenderTargetBinding[] renderTargets)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
      int num = renderTargets != null ? renderTargets.Length : 0;
      if (num == this.currentRenderTargetCount)
      {
        int index = 0;
        while (index < num && (renderTargets[index]._renderTarget == this.currentRenderTargetBindings[index]._renderTarget && renderTargets[index]._cubeMapFace == this.currentRenderTargetBindings[index]._cubeMapFace))
          ++index;
        if (index >= num)
          return;
      }
      if (num > this._profileCapabilities.MaxRenderTargets)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxRenderTargets, (object) this._profileCapabilities.MaxRenderTargets);
      for (int index1 = 0; index1 < num; ++index1)
      {
        Texture renderTarget = renderTargets[index1]._renderTarget;
        if (renderTarget == null)
          throw new ArgumentException(FrameworkResources.NullNotAllowed);
        if (renderTarget._isDisposed)
          throw new ObjectDisposedException(renderTarget.GetType().Name);
        if (renderTarget._parent != this)
          throw new InvalidOperationException(FrameworkResources.InvalidDevice);
        if (index1 > 0)
        {
          for (int index2 = 0; index2 < index1; ++index2)
          {
            if (renderTarget == renderTargets[index2]._renderTarget)
              throw new ArgumentException(FrameworkResources.CannotSetAlreadyUsedRenderTarget);
          }
          if (!RenderTargetHelper.IsSameSize(renderTarget, renderTargets[0]._renderTarget))
            throw new ArgumentException(FrameworkResources.RenderTargetsMustMatch);
        }
      }
      for (int index = 0; index < this.currentRenderTargetCount; ++index)
        this.currentRenderTargetBindings[index]._renderTarget.isActiveRenderTarget = false;
      for (int index = 0; index < num; ++index)
      {
        this.currentRenderTargets[index] = RenderTargetHelper.FromRenderTarget(renderTargets[index]._renderTarget);
        this.currentRenderTargetBindings[index] = renderTargets[index];
        renderTargets[index]._renderTarget.isActiveRenderTarget = true;
      }
      for (int index = num; index < this.currentRenderTargetCount; ++index)
      {
        this.currentRenderTargets[index] = (RenderTargetHelper) null;
        this.currentRenderTargetBindings[index] = new RenderTargetBinding();
      }
      this.currentRenderTargetCount = num;
      this._viewport = new Viewport();
      this._viewport.MaxDepth = 1f;
      if (num > 0)
      {
        this._viewport.Width = this.currentRenderTargets[0].width;
        this._viewport.Height = this.currentRenderTargets[0].height;
      }
      else
      {
        this._viewport.Width = this._internalCachedPresentParams.BackBufferWidth;
        this._viewport.Height = this._internalCachedPresentParams.BackBufferHeight;
      }
      PacketHelpers.SendRenderTargets(this, (uint) num, this.currentRenderTargets, this.currentRenderTargetBindings);
      this._scissorRectDirty = true;
    }

    public void GetBackBufferData<T>(T[] data) where T : struct => this.GetBackBufferData<T>(new Rectangle?(), data, 0, data != null ? data.Length : 0);

    public void GetBackBufferData<T>(T[] data, int startIndex, int elementCount) where T : struct => this.GetBackBufferData<T>(new Rectangle?(), data, startIndex, elementCount);

    [SecuritySafeCritical]
    public unsafe void GetBackBufferData<T>(
      Rectangle? rect,
      T[] data,
      int startIndex,
      int elementCount)
      where T : struct
    {
      if (!this._profileCapabilities.GetBackBufferData)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileFeatureNotSupported, (object) nameof (GetBackBufferData));
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data), FrameworkResources.NullNotAllowed);
      Helpers.ValidateCopyParameters(data.Length, startIndex, elementCount);
      if (this.currentRenderTargetCount > 0)
        throw new InvalidOperationException(FrameworkResources.CannotGetBackBufferActiveRenderTargets);
      Rectangle* pRect = (Rectangle*) null;
      if (rect.HasValue)
        pRect = &rect.Value;
      GCHandle gcHandle = GCHandle.Alloc((object) data, GCHandleType.Pinned);
      try
      {
        uint elementSize = Helpers.GetSizeOf<T>();
        byte* numPtr = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) startIndex * (long) elementSize));
        GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Device.GetGlobal(this).GetBackBufferData(this.pComPtr, (void*) numPtr, new UnsafeNativeStructures.TEXTURE_COPYDATA_INFO(0U, elementSize, (uint) elementCount), pRect));
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void Reset() => this.Reset(this._internalCachedPresentParams, GraphicsAdapter.DefaultAdapter);

    public void Reset(PresentationParameters presentationParameters) => this.Reset(presentationParameters, GraphicsAdapter.DefaultAdapter);

    [SecuritySafeCritical]
    public void Reset(
      PresentationParameters presentationParameters,
      GraphicsAdapter graphicsAdapter)
    {
      if (presentationParameters == null)
        throw new ArgumentNullException(nameof (presentationParameters), FrameworkResources.NullNotAllowed);
      if (graphicsAdapter == null)
        throw new ArgumentNullException(nameof (graphicsAdapter), FrameworkResources.NullNotAllowed);
      if (this.DeviceResetting != null)
        this.DeviceResetting((object) this, EventArgs.Empty);
      SavedDeviceState savedDeviceState = new SavedDeviceState(this, this.currentRenderTargetCount == 0 && presentationParameters.BackBufferWidth == this._internalCachedPresentParams.BackBufferWidth && presentationParameters.BackBufferHeight == this._internalCachedPresentParams.BackBufferHeight);
      this.ValidatePresentationParameters(presentationParameters);
      this.Indices = (IndexBuffer) null;
      this.SetVertexBuffers((VertexBufferBinding[]) null);
      this.SetRenderTargets((RenderTargetBinding[]) null);
      this.Textures.ResetState();
      this.VertexTextures.ResetState();
      this.vertexDeclarationManager.ReleaseAllDeclarations();
      this._vertexShaderActive = false;
      this._pixelShaderActive = false;
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Device.GetGlobal(this).Reset(this.pComPtr, ref presentationParameters.settings));
      this._internalCachedPresentParams = presentationParameters.Clone();
      this._publicCachedPresentParams = presentationParameters.Clone();
      this._scissorRectDirty = true;
      this._viewport = new Viewport();
      this._viewport.Width = this._internalCachedPresentParams.BackBufferWidth;
      this._viewport.Height = this._internalCachedPresentParams.BackBufferHeight;
      this._viewport.MaxDepth = 1f;
      this.InitializeDeviceState();
      savedDeviceState.Restore();
      if (this.DeviceReset == null)
        return;
      this.DeviceReset((object) this, EventArgs.Empty);
    }

    internal void InternalPresent()
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(nameof (GraphicsDevice), FrameworkResources.ObjectDisposedException);
      if (this.currentRenderTargetCount > 0)
        throw new InvalidOperationException(FrameworkResources.CannotPresentActiveRenderTargets);
      GraphicsHelpers.ThrowExceptionFromResult(UnsafeNativeMethods.Device.GetGlobal(this).Present(this.pComPtr));
    }

    public void Present()
    {
      if (this.supportsDirectRendering)
        throw new InvalidOperationException(FrameworkResources.DirectRenderingWrongAppType);
      this.InternalPresent();
    }

    [SuppressMessage("Microsoft.Performance", "CA1801:AvoidUnusedParameters")]
    public void Present(
      Rectangle? sourceRectangle,
      Rectangle? destinationRectangle,
      IntPtr overrideWindowHandle)
    {
      this.Present();
    }

    public void DrawUserIndexedPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int numVertices,
      int[] indexData,
      int indexOffset,
      int primitiveCount,
      VertexDeclaration vertexDeclaration)
      where T : struct
    {
      if (!this._profileCapabilities.IndexElementSize32)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoIndexElementSize32);
      this.DrawUserIndexedPrimitives<T>(primitiveType, vertexData, vertexOffset, numVertices, (Array) indexData, indexOffset, primitiveCount, vertexDeclaration, false);
    }

    public void DrawUserIndexedPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int numVertices,
      short[] indexData,
      int indexOffset,
      int primitiveCount,
      VertexDeclaration vertexDeclaration)
      where T : struct
    {
      this.DrawUserIndexedPrimitives<T>(primitiveType, vertexData, vertexOffset, numVertices, (Array) indexData, indexOffset, primitiveCount, vertexDeclaration, true);
    }

    [SecuritySafeCritical]
    private unsafe void DrawUserIndexedPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int numVertices,
      Array indexData,
      int indexOffset,
      int primitiveCount,
      VertexDeclaration vertexDeclaration,
      bool sixteenBit)
      where T : struct
    {
      if (vertexData == null || vertexData.Length == 0)
        throw new ArgumentNullException(nameof (vertexData), FrameworkResources.NullNotAllowed);
      if (indexData == null || indexData.Length == 0)
        throw new ArgumentNullException(nameof (indexData), FrameworkResources.NullNotAllowed);
      if (vertexDeclaration == null)
        throw new ArgumentNullException(nameof (vertexDeclaration), FrameworkResources.NullNotAllowed);
      if (numVertices <= 0)
        throw new ArgumentOutOfRangeException(nameof (numVertices), FrameworkResources.NumberVerticesMustBeGreaterZero);
      if (primitiveCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (primitiveCount), FrameworkResources.MustDrawSomething);
      if (primitiveCount > this._profileCapabilities.MaxPrimitiveCount)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxPrimitiveCount, (object) this._profileCapabilities.MaxPrimitiveCount);
      if (vertexOffset < 0 || vertexOffset >= vertexData.Length)
        throw new ArgumentOutOfRangeException(nameof (vertexOffset), FrameworkResources.OffsetNotValid);
      if (indexOffset < 0 || indexOffset >= indexData.Length)
        throw new ArgumentOutOfRangeException(nameof (indexOffset), FrameworkResources.OffsetNotValid);
      uint fromPrimitiveType = GraphicsDevice.GetElementCountFromPrimitiveType(primitiveType, primitiveCount);
      if ((long) fromPrimitiveType + (long) indexOffset > (long) indexData.Length)
        throw new ArgumentOutOfRangeException(nameof (primitiveCount), FrameworkResources.MustBeValidIndex);
      if (numVertices + vertexOffset > vertexData.Length)
        throw new ArgumentOutOfRangeException(nameof (vertexData), FrameworkResources.MustBeValidIndex);
      this.VerifyCanDraw(true, true);
      this.BeginUserPrimitives(vertexDeclaration);
      GCHandle gcHandle1 = GCHandle.Alloc((object) vertexData, GCHandleType.Pinned);
      try
      {
        GCHandle gcHandle2 = GCHandle.Alloc((object) indexData, GCHandleType.Pinned);
        try
        {
          uint num1 = Helpers.GetSizeOf<T>();
          byte* pVertexData = (byte*) ((IntPtr) gcHandle1.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) num1 * (long) vertexOffset));
          uint num2 = num1 * (uint) numVertices;
          byte* pointer = (byte*) gcHandle2.AddrOfPinnedObject().ToPointer();
          int num3 = sixteenBit ? 2 : 4;
          byte* pIndexData = pointer + num3 * indexOffset;
          uint num4 = (uint) num3 * fromPrimitiveType;
          if ((long) num2 + (long) num3 < 1536L && ((int) num2 & 3) == 0 && (((int) (uint) pVertexData & 3) == 0 && ((int) (uint) pIndexData & 3) == 0))
          {
            PacketHelpers.SendDrawUserIndexedPrimitivePacket(this, primitiveType, numVertices, primitiveCount, pVertexData, num2, pIndexData, num4, num1, sixteenBit);
          }
          else
          {
            int num5 = (int) UnsafeNativeMethods.Device.GetGlobal(this).DrawUserPrims(this.pComPtr, primitiveType, UnsafeNativeStructures.DUIP_PARAMS.GetParams(0, numVertices, primitiveCount, (void*) pVertexData, num2, (void*) pIndexData, num4, num1, sixteenBit));
            if (num5 == -2147467263)
              throw new InvalidOperationException(FrameworkResources.OutOfMemoryDrawUserPrimitives);
            GraphicsHelpers.ThrowExceptionFromResult((uint) num5);
          }
        }
        finally
        {
          gcHandle2.Free();
        }
      }
      finally
      {
        gcHandle1.Free();
        this._currentIB = (IndexBuffer) null;
      }
    }

    [SecuritySafeCritical]
    public unsafe void DrawUserPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int primitiveCount,
      VertexDeclaration vertexDeclaration)
      where T : struct
    {
      if (vertexData == null)
        throw new ArgumentNullException(nameof (vertexData), FrameworkResources.NullNotAllowed);
      if (vertexDeclaration == null)
        throw new ArgumentNullException(nameof (vertexDeclaration), FrameworkResources.NullNotAllowed);
      if (primitiveCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (primitiveCount), FrameworkResources.MustDrawSomething);
      if (primitiveCount > this._profileCapabilities.MaxPrimitiveCount)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxPrimitiveCount, (object) this._profileCapabilities.MaxPrimitiveCount);
      if (vertexOffset < 0 || vertexOffset >= vertexData.Length)
        throw new ArgumentOutOfRangeException(nameof (vertexOffset), FrameworkResources.OffsetNotValid);
      uint fromPrimitiveType = GraphicsDevice.GetElementCountFromPrimitiveType(primitiveType, primitiveCount);
      if ((long) fromPrimitiveType + (long) vertexOffset > (long) vertexData.Length)
        throw new ArgumentOutOfRangeException(nameof (primitiveCount), FrameworkResources.MustBeValidIndex);
      this.VerifyCanDraw(true, true);
      this.BeginUserPrimitives(vertexDeclaration);
      GCHandle gcHandle = GCHandle.Alloc((object) vertexData, GCHandleType.Pinned);
      try
      {
        uint num1 = Helpers.GetSizeOf<T>();
        byte* pVertexData = (byte*) ((IntPtr) gcHandle.AddrOfPinnedObject().ToPointer() + (IntPtr) ((long) num1 * (long) vertexOffset));
        uint num2 = num1 * fromPrimitiveType;
        if (num2 < 1536U && ((int) num2 & 3) == 0 && ((int) (uint) pVertexData & 3) == 0)
        {
          PacketHelpers.SendDrawUserPrimitivePacket(this, primitiveType, primitiveCount, pVertexData, num2, num1);
        }
        else
        {
          int num3 = (int) UnsafeNativeMethods.Device.GetGlobal(this).DrawUserPrims(this.pComPtr, primitiveType, (uint) primitiveCount, (void*) pVertexData, num2, num1);
          if (num3 == -2147467263)
            throw new InvalidOperationException(FrameworkResources.OutOfMemoryDrawUserPrimitives);
          GraphicsHelpers.ThrowExceptionFromResult((uint) num3);
        }
      }
      finally
      {
        gcHandle.Free();
      }
    }

    public void DrawUserPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int primitiveCount)
      where T : struct, IVertexType
    {
      this.DrawUserPrimitives<T>(primitiveType, vertexData, vertexOffset, primitiveCount, VertexDeclarationFactory<T>.VertexDeclaration);
    }

    public void DrawUserIndexedPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int numVertices,
      int[] indexData,
      int indexOffset,
      int primitiveCount)
      where T : struct, IVertexType
    {
      if (!this._profileCapabilities.IndexElementSize32)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoIndexElementSize32);
      this.DrawUserIndexedPrimitives<T>(primitiveType, vertexData, vertexOffset, numVertices, (Array) indexData, indexOffset, primitiveCount, VertexDeclarationFactory<T>.VertexDeclaration, false);
    }

    public void DrawUserIndexedPrimitives<T>(
      PrimitiveType primitiveType,
      T[] vertexData,
      int vertexOffset,
      int numVertices,
      short[] indexData,
      int indexOffset,
      int primitiveCount)
      where T : struct, IVertexType
    {
      this.DrawUserIndexedPrimitives<T>(primitiveType, vertexData, vertexOffset, numVertices, (Array) indexData, indexOffset, primitiveCount, VertexDeclarationFactory<T>.VertexDeclaration, true);
    }

    public void DrawIndexedPrimitives(
      PrimitiveType primitiveType,
      int baseVertex,
      int minVertexIndex,
      int numVertices,
      int startIndex,
      int primitiveCount)
    {
      if (numVertices <= 0)
        throw new ArgumentOutOfRangeException(nameof (numVertices), FrameworkResources.NumberVerticesMustBeGreaterZero);
      if (primitiveCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (primitiveCount), FrameworkResources.MustDrawSomething);
      if (primitiveCount > this._profileCapabilities.MaxPrimitiveCount)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxPrimitiveCount, (object) this._profileCapabilities.MaxPrimitiveCount);
      this.VerifyCanDraw(false, true);
      PacketHelpers.SendDrawIndexedPrimitivePacket(this, primitiveType, baseVertex, minVertexIndex, numVertices, startIndex, primitiveCount);
    }

    public void DrawPrimitives(PrimitiveType primitiveType, int startVertex, int primitiveCount)
    {
      if (primitiveCount <= 0)
        throw new ArgumentOutOfRangeException(nameof (primitiveCount), FrameworkResources.MustDrawSomething);
      if (primitiveCount > this._profileCapabilities.MaxPrimitiveCount)
        this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileMaxPrimitiveCount, (object) this._profileCapabilities.MaxPrimitiveCount);
      this.VerifyCanDraw(false, false);
      PacketHelpers.SendDrawPrimitivePacket(this, primitiveType, startVertex, primitiveCount);
    }

    public void DrawInstancedPrimitives(
      PrimitiveType primitiveType,
      int baseVertex,
      int minVertexIndex,
      int numVertices,
      int startIndex,
      int primitiveCount,
      int instanceCount)
    {
      throw new NotSupportedException(FrameworkResources.MobileNoInstancing);
    }

    public BlendState BlendState
    {
      get => this.cachedBlendState;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value), FrameworkResources.NullNotAllowed);
        if (value == this.cachedBlendState && !this.blendStateDirty)
          return;
        if (value._isDisposed)
          throw new ObjectDisposedException(typeof (BlendState).Name);
        if (value._parent != this)
          value.Bind(this);
        PacketHelpers.SendResourceSetPacket(this, HLCBPacketType.SetBlendState, value.pComPtr);
        this.cachedBlendState = value;
        this.cachedBlendFactor = value.settings.BlendFactor;
        this.cachedMultiSampleMask = value.settings.MultiSampleMask;
        this.blendStateDirty = false;
      }
    }

    public Color BlendFactor
    {
      get => this.cachedBlendFactor;
      set
      {
        PacketHelpers.SendSetHighFrequencyStatePacket(this, HighFrequencyRenderState.BlendFactor, value.PackedValue);
        this.cachedBlendFactor = value;
        this.blendStateDirty = true;
      }
    }

    public int MultiSampleMask
    {
      get => this.cachedMultiSampleMask;
      set
      {
        PacketHelpers.SendSetHighFrequencyStatePacket(this, HighFrequencyRenderState.MultiSampleMask, (uint) value);
        this.cachedMultiSampleMask = value;
        this.blendStateDirty = true;
      }
    }

    public DepthStencilState DepthStencilState
    {
      get => this.cachedDepthStencilState;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value), FrameworkResources.NullNotAllowed);
        if (value == this.cachedDepthStencilState && !this.depthStencilStateDirty)
          return;
        if (value._isDisposed)
          throw new ObjectDisposedException(typeof (DepthStencilState).Name);
        if (value._parent != this)
          value.Bind(this);
        PacketHelpers.SendResourceSetPacket(this, HLCBPacketType.SetDepthStencilState, value.pComPtr);
        this.cachedDepthStencilState = value;
        this.cachedReferenceStencil = value.settings.ReferenceStencil;
        this.depthStencilStateDirty = false;
      }
    }

    public int ReferenceStencil
    {
      get => this.cachedReferenceStencil;
      set
      {
        PacketHelpers.SendSetHighFrequencyStatePacket(this, HighFrequencyRenderState.ReferenceStencil, (uint) value);
        this.cachedReferenceStencil = value;
        this.depthStencilStateDirty = true;
      }
    }

    public RasterizerState RasterizerState
    {
      get => this.cachedRasterizerState;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value), FrameworkResources.NullNotAllowed);
        if (value == this.cachedRasterizerState)
          return;
        if (value._isDisposed)
          throw new ObjectDisposedException(typeof (RasterizerState).Name);
        if (value._parent != this)
          value.Bind(this);
        PacketHelpers.SendResourceSetPacket(this, HLCBPacketType.SetRasterizerState, value.pComPtr);
        this.cachedRasterizerState = value;
      }
    }

    private void VerifyCanDraw(bool userPrimitives, bool indexed)
    {
      if (!this._vertexShaderActive || !this._pixelShaderActive)
        throw new InvalidOperationException(FrameworkResources.CannotDrawNoShader);
      if (userPrimitives)
        return;
      if (indexed && this._currentIB == null)
        throw new InvalidOperationException(FrameworkResources.CannotDrawNoData);
      if (this.currentVertexBufferCount <= 0)
        throw new InvalidOperationException(FrameworkResources.CannotDrawNoData);
    }

    [SecuritySafeCritical]
    internal unsafe void FlushBuffer()
    {
      lock (GraphicsDevice.packetSyncObject)
      {
        if (this.currentPacketSize > 0U)
        {
          fixed (byte* pPacketData = &this.currentPacket[0])
          {
            uint result = UnsafeNativeMethods.Device.SendHLCBPacket(this.pComPtr, pPacketData, this.currentPacketSize);
            if (result != 0U)
            {
              this.currentPacketSize = 0U;
              this.ThrowExceptionFromFlushResult(result);
            }
          }
        }
        this.currentPacketSize = 0U;
      }
    }

    internal void ClearBlendState()
    {
      this.cachedBlendState = (BlendState) null;
      this.cachedBlendFactor = BlendState.Opaque.BlendFactor;
      this.cachedMultiSampleMask = BlendState.Opaque.MultiSampleMask;
      this.blendStateDirty = true;
    }

    internal void ClearDepthStencilState()
    {
      this.cachedDepthStencilState = (DepthStencilState) null;
      this.cachedReferenceStencil = DepthStencilState.Default.ReferenceStencil;
      this.depthStencilStateDirty = true;
    }

    internal void ClearRasterizerState() => this.cachedRasterizerState = (RasterizerState) null;

    private void ThrowExceptionFromFlushResult(uint result)
    {
      switch ((FlushError) result)
      {
        case FlushError.MissingVertexShaderInput:
          string message = FrameworkResources.MissingVertexShaderInput;
          uint data1;
          uint data2;
          if (UnsafeNativeMethods.Adapter.GetLastErrorDetails(result, out data1, out data2) == 0U)
            message = string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.MissingVertexShaderInputDetails, (object) message, (object) (VertexElementUsage) data1, (object) (int) data2);
          throw new InvalidOperationException(message);
        case FlushError.NonZeroInstanceFrequency:
          throw new InvalidOperationException(FrameworkResources.NonZeroInstanceFrequency);
        case FlushError.VertexTextureFormatNotSupported:
          this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileVertexTextureFormatNotSupported, (object) this.GetLastErrorTextureFormat(result));
          break;
        case FlushError.InvalidBlendFormat:
          this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileInvalidBlendFormat, (object) this.GetLastErrorTextureFormat(result));
          break;
        case FlushError.InvalidFilterFormat:
          this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileInvalidFilterFormat, (object) this.GetLastErrorTextureFormat(result));
          break;
        case FlushError.WrapNonPow2:
          this._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoWrapNonPow2);
          break;
        case FlushError.InvalidInstanceStreams:
          throw new InvalidOperationException(FrameworkResources.InvalidInstanceStreams);
        case FlushError.InvalidRenderingMode:
          throw new InvalidOperationException(FrameworkResources.DirectRenderingWrongMode);
        default:
          throw new InvalidOperationException(FrameworkResources.DriverError, GraphicsHelpers.GetExceptionFromResult(result));
      }
    }

    private SurfaceFormat GetLastErrorTextureFormat(uint result)
    {
      uint data1;
      return UnsafeNativeMethods.Adapter.GetLastErrorDetails(result, out data1, out uint _) == 0U && this.GetKnownResourceFromHandle(data1) is Texture resourceFromHandle ? resourceFromHandle.Format : ~SurfaceFormat.Color;
    }

    private static uint GetElementCountFromPrimitiveType(
      PrimitiveType primitiveType,
      int primitiveCount)
    {
      uint num = uint.MaxValue;
      switch (primitiveType)
      {
        case PrimitiveType.TriangleList:
          num = (uint) (primitiveCount * 3);
          break;
        case PrimitiveType.TriangleStrip:
          num = (uint) (primitiveCount + 2);
          break;
        case PrimitiveType.LineList:
          num = (uint) (primitiveCount * 2);
          break;
        case PrimitiveType.LineStrip:
          num = (uint) (primitiveCount + 1);
          break;
      }
      return num;
    }

    private ClearOptions DefaultClearOptions
    {
      get
      {
        ClearOptions clearOptions = ClearOptions.Target;
        DepthFormat depthFormat = this.currentRenderTargetCount > 0 ? this.currentRenderTargets[0].depthFormat : this._internalCachedPresentParams.DepthStencilFormat;
        if (depthFormat != DepthFormat.None)
        {
          clearOptions |= ClearOptions.DepthBuffer;
          if (depthFormat == DepthFormat.Depth24Stencil8)
            clearOptions |= ClearOptions.Stencil;
        }
        return clearOptions;
      }
    }

    internal void BeginUserPrimitives(VertexDeclaration vertexDeclaration)
    {
      for (int stream = 0; stream < this.currentVertexBufferCount; ++stream)
      {
        if (stream > 0)
          PacketHelpers.AddSetStreamSource(this, stream, 0U, 0, 0, 0);
        this.currentVertexBuffers[stream] = new VertexBufferBinding();
      }
      this.currentVertexBufferCount = 0;
      this.vertexDeclarationManager.SetVertexDeclaration(vertexDeclaration);
    }

    internal void FireCreatedEvent(object resource, uint handle)
    {
      if (handle != 0U && handle != uint.MaxValue)
      {
        lock (this._knownResources)
          this._knownResources[handle] = new WeakReference(resource);
      }
      if (this.ResourceCreated == null)
        return;
      this.ResourceCreated((object) this, new ResourceCreatedEventArgs(resource));
    }

    internal void FireDestroyedEvent(string name, object tag, uint handle)
    {
      if (handle != 0U && handle != uint.MaxValue)
      {
        lock (this._knownResources)
          this._knownResources.Remove(handle);
      }
      if (this.ResourceDestroyed == null)
        return;
      this.ResourceDestroyed((object) this, new ResourceDestroyedEventArgs(name, tag));
    }

    internal object GetKnownResourceFromHandle(uint handle)
    {
      lock (this._knownResources)
      {
        WeakReference weakReference;
        if (this._knownResources.TryGetValue(handle, out weakReference))
        {
          try
          {
            return weakReference.Target;
          }
          catch (InvalidOperationException ex)
          {
            return (object) null;
          }
        }
      }
      return (object) null;
    }

    public bool IsDisposed => this._isDisposed;

    public event EventHandler<EventArgs> Disposing;

    ~GraphicsDevice() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", Justification = "All non-implicit surfaces are destoryed magically when the device is.", MessageId = "_depthStencilSurface")]
    protected virtual void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      this._isDisposed = true;
      if (this.vertexDeclarationManager != null)
        this.vertexDeclarationManager.ReleaseAllDeclarations();
      if (this.pComPtr != uint.MaxValue)
        UnsafeNativeMethods.Device.GetGlobal(this).ReleaseHandle(this.pComPtr);
      if (!disposing || this.Disposing == null)
        return;
      this.Disposing((object) this, EventArgs.Empty);
    }
  }
}
