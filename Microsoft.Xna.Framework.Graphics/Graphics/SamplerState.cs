// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.SamplerState
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public class SamplerState : GraphicsResource
  {
    internal SamplerState.Settings settings;
    private bool isBound;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SamplerState PointWrap;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SamplerState PointClamp;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SamplerState LinearWrap;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SamplerState LinearClamp;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SamplerState AnisotropicWrap;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly SamplerState AnisotropicClamp;

    public TextureFilter Filter
    {
      get => this.settings.Filter;
      set
      {
        this.ThrowIfBound();
        this.settings.Filter = value;
      }
    }

    public TextureAddressMode AddressU
    {
      get => this.settings.AddressU;
      set
      {
        this.ThrowIfBound();
        this.settings.AddressU = value;
      }
    }

    public TextureAddressMode AddressV
    {
      get => this.settings.AddressV;
      set
      {
        this.ThrowIfBound();
        this.settings.AddressV = value;
      }
    }

    public TextureAddressMode AddressW
    {
      get => this.settings.AddressW;
      set
      {
        this.ThrowIfBound();
        this.settings.AddressW = value;
      }
    }

    public int MaxAnisotropy
    {
      get => this.settings.MaxAnisotropy;
      set
      {
        this.ThrowIfBound();
        this.settings.MaxAnisotropy = value;
      }
    }

    public int MaxMipLevel
    {
      get => this.settings.MaxMipLevel;
      set
      {
        this.ThrowIfBound();
        this.settings.MaxMipLevel = value;
      }
    }

    public float MipMapLevelOfDetailBias
    {
      get => this.settings.MipMapLevelOfDetailBias;
      set
      {
        this.ThrowIfBound();
        this.settings.MipMapLevelOfDetailBias = value;
      }
    }

    public SamplerState()
    {
      this.Filter = TextureFilter.Linear;
      this.AddressU = TextureAddressMode.Wrap;
      this.AddressV = TextureAddressMode.Wrap;
      this.AddressW = TextureAddressMode.Wrap;
      this.MaxAnisotropy = 4;
      this.MaxMipLevel = 0;
      this.MipMapLevelOfDetailBias = 0.0f;
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
      this.pComPtr = UnsafeNativeMethods.Device.GetGlobal(this._parent).CreateSamplerState(device.pComPtr, ref this.settings);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = device;
      this.isBound = true;
    }

    private void Unbind()
    {
      if (this.pComPtr == uint.MaxValue)
        return;
      UnsafeNativeMethods.Device.GetGlobal(this._parent).ReleaseSamplerState(this.pComPtr);
      this.pComPtr = uint.MaxValue;
    }

    private void ThrowIfBound()
    {
      if (this.isBound)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.BoundStateObject, (object) typeof (SamplerState).Name));
    }

    static SamplerState()
    {
      SamplerState samplerState1 = new SamplerState();
      samplerState1.Name = "SamplerState.PointWrap";
      samplerState1.Filter = TextureFilter.Point;
      samplerState1.AddressU = TextureAddressMode.Wrap;
      samplerState1.AddressV = TextureAddressMode.Wrap;
      samplerState1.AddressW = TextureAddressMode.Wrap;
      samplerState1.isBound = true;
      SamplerState.PointWrap = samplerState1;
      SamplerState samplerState2 = new SamplerState();
      samplerState2.Name = "SamplerState.PointClamp";
      samplerState2.Filter = TextureFilter.Point;
      samplerState2.AddressU = TextureAddressMode.Clamp;
      samplerState2.AddressV = TextureAddressMode.Clamp;
      samplerState2.AddressW = TextureAddressMode.Clamp;
      samplerState2.isBound = true;
      SamplerState.PointClamp = samplerState2;
      SamplerState samplerState3 = new SamplerState();
      samplerState3.Name = "SamplerState.LinearWrap";
      samplerState3.Filter = TextureFilter.Linear;
      samplerState3.AddressU = TextureAddressMode.Wrap;
      samplerState3.AddressV = TextureAddressMode.Wrap;
      samplerState3.AddressW = TextureAddressMode.Wrap;
      samplerState3.isBound = true;
      SamplerState.LinearWrap = samplerState3;
      SamplerState samplerState4 = new SamplerState();
      samplerState4.Name = "SamplerState.LinearClamp";
      samplerState4.Filter = TextureFilter.Linear;
      samplerState4.AddressU = TextureAddressMode.Clamp;
      samplerState4.AddressV = TextureAddressMode.Clamp;
      samplerState4.AddressW = TextureAddressMode.Clamp;
      samplerState4.isBound = true;
      SamplerState.LinearClamp = samplerState4;
      SamplerState samplerState5 = new SamplerState();
      samplerState5.Name = "SamplerState.AnisotropicWrap";
      samplerState5.Filter = TextureFilter.Anisotropic;
      samplerState5.AddressU = TextureAddressMode.Wrap;
      samplerState5.AddressV = TextureAddressMode.Wrap;
      samplerState5.AddressW = TextureAddressMode.Wrap;
      samplerState5.isBound = true;
      SamplerState.AnisotropicWrap = samplerState5;
      SamplerState samplerState6 = new SamplerState();
      samplerState6.Name = "SamplerState.AnisotropicClamp";
      samplerState6.Filter = TextureFilter.Anisotropic;
      samplerState6.AddressU = TextureAddressMode.Clamp;
      samplerState6.AddressV = TextureAddressMode.Clamp;
      samplerState6.AddressW = TextureAddressMode.Clamp;
      samplerState6.isBound = true;
      SamplerState.AnisotropicClamp = samplerState6;
    }

    internal struct Settings
    {
      internal TextureFilter Filter;
      internal TextureAddressMode AddressU;
      internal TextureAddressMode AddressV;
      internal TextureAddressMode AddressW;
      internal int MaxAnisotropy;
      internal int MaxMipLevel;
      internal float MipMapLevelOfDetailBias;
    }
  }
}
