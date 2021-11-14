// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DepthStencilState
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public class DepthStencilState : GraphicsResource
  {
    internal DepthStencilState.Settings settings;
    private bool isBound;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly DepthStencilState None;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly DepthStencilState Default;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly DepthStencilState DepthRead;

    public bool DepthBufferEnable
    {
      get => (uint) this.settings.DepthBufferEnable > 0U;
      set
      {
        this.ThrowIfBound();
        this.settings.DepthBufferEnable = value ? 1 : 0;
      }
    }

    public bool DepthBufferWriteEnable
    {
      get => (uint) this.settings.DepthBufferWriteEnable > 0U;
      set
      {
        this.ThrowIfBound();
        this.settings.DepthBufferWriteEnable = value ? 1 : 0;
      }
    }

    public CompareFunction DepthBufferFunction
    {
      get => this.settings.DepthBufferFunction;
      set
      {
        this.ThrowIfBound();
        this.settings.DepthBufferFunction = value;
      }
    }

    public bool StencilEnable
    {
      get => (uint) this.settings.StencilEnable > 0U;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilEnable = value ? 1 : 0;
      }
    }

    public CompareFunction StencilFunction
    {
      get => this.settings.StencilFunction;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilFunction = value;
      }
    }

    public StencilOperation StencilPass
    {
      get => this.settings.StencilPass;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilPass = value;
      }
    }

    public StencilOperation StencilFail
    {
      get => this.settings.StencilFail;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilFail = value;
      }
    }

    public StencilOperation StencilDepthBufferFail
    {
      get => this.settings.StencilDepthBufferFail;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilDepthBufferFail = value;
      }
    }

    public bool TwoSidedStencilMode
    {
      get => (uint) this.settings.TwoSidedStencilMode > 0U;
      set
      {
        this.ThrowIfBound();
        this.settings.TwoSidedStencilMode = value ? 1 : 0;
      }
    }

    public CompareFunction CounterClockwiseStencilFunction
    {
      get => this.settings.CounterClockwiseStencilFunction;
      set
      {
        this.ThrowIfBound();
        this.settings.CounterClockwiseStencilFunction = value;
      }
    }

    public StencilOperation CounterClockwiseStencilPass
    {
      get => this.settings.CounterClockwiseStencilPass;
      set
      {
        this.ThrowIfBound();
        this.settings.CounterClockwiseStencilPass = value;
      }
    }

    public StencilOperation CounterClockwiseStencilFail
    {
      get => this.settings.CounterClockwiseStencilFail;
      set
      {
        this.ThrowIfBound();
        this.settings.CounterClockwiseStencilFail = value;
      }
    }

    public StencilOperation CounterClockwiseStencilDepthBufferFail
    {
      get => this.settings.CounterClockwiseStencilDepthBufferFail;
      set
      {
        this.ThrowIfBound();
        this.settings.CounterClockwiseStencilDepthBufferFail = value;
      }
    }

    public int StencilMask
    {
      get => this.settings.StencilMask;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilMask = value;
      }
    }

    public int StencilWriteMask
    {
      get => this.settings.StencilWriteMask;
      set
      {
        this.ThrowIfBound();
        this.settings.StencilWriteMask = value;
      }
    }

    public int ReferenceStencil
    {
      get => this.settings.ReferenceStencil;
      set
      {
        this.ThrowIfBound();
        this.settings.ReferenceStencil = value;
      }
    }

    public DepthStencilState()
    {
      this.DepthBufferEnable = true;
      this.DepthBufferWriteEnable = true;
      this.DepthBufferFunction = CompareFunction.LessEqual;
      this.StencilEnable = false;
      this.StencilFunction = CompareFunction.Always;
      this.StencilPass = StencilOperation.Keep;
      this.StencilFail = StencilOperation.Keep;
      this.StencilDepthBufferFail = StencilOperation.Keep;
      this.TwoSidedStencilMode = false;
      this.CounterClockwiseStencilFunction = CompareFunction.Always;
      this.CounterClockwiseStencilPass = StencilOperation.Keep;
      this.CounterClockwiseStencilFail = StencilOperation.Keep;
      this.CounterClockwiseStencilDepthBufferFail = StencilOperation.Keep;
      this.StencilMask = -1;
      this.StencilWriteMask = -1;
      this.ReferenceStencil = 0;
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        this.Unbind();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    internal void Bind(GraphicsDevice device)
    {
      this.Unbind();
      this.pComPtr = UnsafeNativeMethods.Device.GetGlobal(this._parent).CreateDepthStencilState(device.pComPtr, ref this.settings);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = device;
      this.isBound = true;
    }

    private void Unbind()
    {
      if (this.pComPtr == uint.MaxValue)
        return;
      UnsafeNativeMethods.Device.GetGlobal(this._parent).ReleaseDepthStencilState(this.pComPtr);
      this.pComPtr = uint.MaxValue;
    }

    private void ThrowIfBound()
    {
      if (this.isBound)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.BoundStateObject, (object) typeof (DepthStencilState).Name));
    }

    static DepthStencilState()
    {
      DepthStencilState depthStencilState1 = new DepthStencilState();
      depthStencilState1.Name = "DepthStencilState.None";
      depthStencilState1.DepthBufferEnable = false;
      depthStencilState1.DepthBufferWriteEnable = false;
      depthStencilState1.isBound = true;
      DepthStencilState.None = depthStencilState1;
      DepthStencilState depthStencilState2 = new DepthStencilState();
      depthStencilState2.Name = "DepthStencilState.Default";
      depthStencilState2.DepthBufferEnable = true;
      depthStencilState2.DepthBufferWriteEnable = true;
      depthStencilState2.isBound = true;
      DepthStencilState.Default = depthStencilState2;
      DepthStencilState depthStencilState3 = new DepthStencilState();
      depthStencilState3.Name = "DepthStencilState.DepthRead";
      depthStencilState3.DepthBufferEnable = true;
      depthStencilState3.DepthBufferWriteEnable = false;
      depthStencilState3.isBound = true;
      DepthStencilState.DepthRead = depthStencilState3;
    }

    internal struct Settings
    {
      internal int DepthBufferEnable;
      internal int DepthBufferWriteEnable;
      internal CompareFunction DepthBufferFunction;
      internal int StencilEnable;
      internal CompareFunction StencilFunction;
      internal StencilOperation StencilPass;
      internal StencilOperation StencilFail;
      internal StencilOperation StencilDepthBufferFail;
      internal int TwoSidedStencilMode;
      internal CompareFunction CounterClockwiseStencilFunction;
      internal StencilOperation CounterClockwiseStencilPass;
      internal StencilOperation CounterClockwiseStencilFail;
      internal StencilOperation CounterClockwiseStencilDepthBufferFail;
      internal int StencilMask;
      internal int StencilWriteMask;
      internal int ReferenceStencil;
    }
  }
}
