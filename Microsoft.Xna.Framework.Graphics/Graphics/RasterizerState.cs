// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.RasterizerState
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public class RasterizerState : GraphicsResource
  {
    internal RasterizerState.Settings settings;
    private bool isBound;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly RasterizerState CullNone;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly RasterizerState CullClockwise;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly RasterizerState CullCounterClockwise;

    public CullMode CullMode
    {
      get => this.settings.CullMode;
      set
      {
        this.ThrowIfBound();
        this.settings.CullMode = value;
      }
    }

    public FillMode FillMode
    {
      get => this.settings.FillMode;
      set
      {
        this.ThrowIfBound();
        this.settings.FillMode = value;
      }
    }

    public bool ScissorTestEnable
    {
      get => (uint) this.settings.ScissorTestEnable > 0U;
      set
      {
        this.ThrowIfBound();
        this.settings.ScissorTestEnable = value ? 1 : 0;
      }
    }

    public bool MultiSampleAntiAlias
    {
      get => (uint) this.settings.MultiSampleAntiAlias > 0U;
      set
      {
        this.ThrowIfBound();
        this.settings.MultiSampleAntiAlias = value ? 1 : 0;
      }
    }

    public float DepthBias
    {
      get => this.settings.DepthBias;
      set
      {
        this.ThrowIfBound();
        this.settings.DepthBias = value;
      }
    }

    public float SlopeScaleDepthBias
    {
      get => this.settings.SlopeScaleDepthBias;
      set
      {
        this.ThrowIfBound();
        this.settings.SlopeScaleDepthBias = value;
      }
    }

    public RasterizerState()
    {
      this.CullMode = CullMode.CullCounterClockwiseFace;
      this.FillMode = FillMode.Solid;
      this.ScissorTestEnable = false;
      this.MultiSampleAntiAlias = true;
      this.DepthBias = 0.0f;
      this.SlopeScaleDepthBias = 0.0f;
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
      this.pComPtr = UnsafeNativeMethods.Device.GetGlobal(this._parent).CreateRasterizerState(device.pComPtr, ref this.settings);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = device;
      this.isBound = true;
    }

    private void Unbind()
    {
      if (this.pComPtr == uint.MaxValue)
        return;
      UnsafeNativeMethods.Device.GetGlobal(this._parent).ReleaseRasterizerState(this.pComPtr);
      this.pComPtr = uint.MaxValue;
    }

    private void ThrowIfBound()
    {
      if (this.isBound)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.BoundStateObject, (object) typeof (RasterizerState).Name));
    }

    static RasterizerState()
    {
      RasterizerState rasterizerState1 = new RasterizerState();
      rasterizerState1.Name = "RasterizerState.CullNone";
      rasterizerState1.CullMode = CullMode.None;
      rasterizerState1.isBound = true;
      RasterizerState.CullNone = rasterizerState1;
      RasterizerState rasterizerState2 = new RasterizerState();
      rasterizerState2.Name = "RasterizerState.CullClockwise";
      rasterizerState2.CullMode = CullMode.CullClockwiseFace;
      rasterizerState2.isBound = true;
      RasterizerState.CullClockwise = rasterizerState2;
      RasterizerState rasterizerState3 = new RasterizerState();
      rasterizerState3.Name = "RasterizerState.CullCounterClockwise";
      rasterizerState3.CullMode = CullMode.CullCounterClockwiseFace;
      rasterizerState3.isBound = true;
      RasterizerState.CullCounterClockwise = rasterizerState3;
    }

    internal struct Settings
    {
      internal CullMode CullMode;
      internal FillMode FillMode;
      internal int ScissorTestEnable;
      internal int MultiSampleAntiAlias;
      internal float DepthBias;
      internal float SlopeScaleDepthBias;
    }
  }
}
