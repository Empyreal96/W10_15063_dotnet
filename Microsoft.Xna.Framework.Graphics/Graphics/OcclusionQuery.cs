// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.OcclusionQuery
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;

namespace Microsoft.Xna.Framework.Graphics
{
  public class OcclusionQuery : GraphicsResource
  {
    private int _pixelCount;
    private bool _isAvailable;
    private bool _isInBeginEndPair;
    private bool _hasBeginBeenCalled;
    private bool _hasIsCompleteBeenQueried = true;

    public OcclusionQuery(GraphicsDevice graphicsDevice)
    {
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      if (!graphicsDevice._profileCapabilities.OcclusionQuery)
        graphicsDevice._profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileFeatureNotSupported, (object) typeof (OcclusionQuery).Name);
      this.pComPtr = UnsafeNativeMethods.OcclusionQuery.GetGlobal(graphicsDevice).CreateHandle(graphicsDevice.pComPtr);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = graphicsDevice;
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    public void Begin()
    {
      if (this._isInBeginEndPair)
        throw new InvalidOperationException(FrameworkResources.EndMustBeCalledBeforeBegin);
      if (!this._hasIsCompleteBeenQueried)
        throw new InvalidOperationException(FrameworkResources.IsCompleteMustBeCalled);
      this._isAvailable = false;
      PacketHelpers.SendQueryPacket(this._parent, this, HLCBPacketType.BeginQuery);
      this._isInBeginEndPair = true;
      this._hasBeginBeenCalled = true;
      this._hasIsCompleteBeenQueried = false;
    }

    public void End()
    {
      if (!this._isInBeginEndPair)
        throw new InvalidOperationException(FrameworkResources.BeginMustBeCalledBeforeEnd);
      PacketHelpers.SendQueryPacket(this._parent, this, HLCBPacketType.EndQuery);
      this._isInBeginEndPair = false;
    }

    public bool IsComplete
    {
      get
      {
        this._hasIsCompleteBeenQueried = true;
        if (!this._hasBeginBeenCalled)
          return false;
        uint pixelCount;
        if (!this._isAvailable && UnsafeNativeMethods.OcclusionQuery.GetGlobal(this._parent).IsDataAvailable(this._parent.pComPtr, this.pComPtr, out pixelCount) != 0U)
        {
          this._isAvailable = true;
          this._pixelCount = (int) pixelCount;
        }
        return this._isAvailable;
      }
    }

    public int PixelCount
    {
      get
      {
        if (!this.IsComplete)
          throw new InvalidOperationException(FrameworkResources.DataNotAvailable);
        return this._pixelCount;
      }
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.OcclusionQuery.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
        if (this._parent == null)
          return;
        this._parent.FireDestroyedEvent(this._name, this._tag, this.pComPtr);
      }
      finally
      {
        base.Dispose(disposing);
      }
    }
  }
}
