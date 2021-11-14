// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.BlendState
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Microsoft.Xna.Framework.Graphics
{
  public class BlendState : GraphicsResource
  {
    internal BlendState.Settings settings;
    private bool isBound;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly BlendState Opaque;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly BlendState AlphaBlend;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly BlendState Additive;
    [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly BlendState NonPremultiplied;

    public Blend ColorSourceBlend
    {
      get => this.settings.ColorSourceBlend;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorSourceBlend = value;
      }
    }

    public Blend ColorDestinationBlend
    {
      get => this.settings.ColorDestinationBlend;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorDestinationBlend = value;
      }
    }

    public BlendFunction ColorBlendFunction
    {
      get => this.settings.ColorBlendFunction;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorBlendFunction = value;
      }
    }

    public Blend AlphaSourceBlend
    {
      get => this.settings.AlphaSourceBlend;
      set
      {
        this.ThrowIfBound();
        this.settings.AlphaSourceBlend = value;
      }
    }

    public Blend AlphaDestinationBlend
    {
      get => this.settings.AlphaDestinationBlend;
      set
      {
        this.ThrowIfBound();
        this.settings.AlphaDestinationBlend = value;
      }
    }

    public BlendFunction AlphaBlendFunction
    {
      get => this.settings.AlphaBlendFunction;
      set
      {
        this.ThrowIfBound();
        this.settings.AlphaBlendFunction = value;
      }
    }

    public ColorWriteChannels ColorWriteChannels
    {
      get => this.settings.ColorWriteChannels;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorWriteChannels = value;
      }
    }

    public ColorWriteChannels ColorWriteChannels1
    {
      get => this.settings.ColorWriteChannels1;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorWriteChannels1 = value;
      }
    }

    public ColorWriteChannels ColorWriteChannels2
    {
      get => this.settings.ColorWriteChannels2;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorWriteChannels2 = value;
      }
    }

    public ColorWriteChannels ColorWriteChannels3
    {
      get => this.settings.ColorWriteChannels3;
      set
      {
        this.ThrowIfBound();
        this.settings.ColorWriteChannels3 = value;
      }
    }

    public Color BlendFactor
    {
      get => this.settings.BlendFactor;
      set
      {
        this.ThrowIfBound();
        this.settings.BlendFactor = value;
      }
    }

    public int MultiSampleMask
    {
      get => this.settings.MultiSampleMask;
      set
      {
        this.ThrowIfBound();
        this.settings.MultiSampleMask = value;
      }
    }

    public BlendState()
    {
      this.ColorSourceBlend = Blend.One;
      this.ColorDestinationBlend = Blend.Zero;
      this.ColorBlendFunction = BlendFunction.Add;
      this.AlphaSourceBlend = Blend.One;
      this.AlphaDestinationBlend = Blend.Zero;
      this.AlphaBlendFunction = BlendFunction.Add;
      this.ColorWriteChannels = ColorWriteChannels.All;
      this.ColorWriteChannels1 = ColorWriteChannels.All;
      this.ColorWriteChannels2 = ColorWriteChannels.All;
      this.ColorWriteChannels3 = ColorWriteChannels.All;
      this.BlendFactor = Color.White;
      this.MultiSampleMask = -1;
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
      ProfileCapabilities profileCapabilities = device._profileCapabilities;
      if (!profileCapabilities.SeparateAlphaBlend)
      {
        if (GraphicsHelpers.IsSeparateBlend(this.ColorSourceBlend, this.AlphaSourceBlend))
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoSeparateAlphaBlend, (object) "ColorSourceBlend", (object) "AlphaSourceBlend");
        if (GraphicsHelpers.IsSeparateBlend(this.ColorDestinationBlend, this.AlphaDestinationBlend))
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoSeparateAlphaBlend, (object) "ColorDestinationBlend", (object) "AlphaDestinationBlend");
        if (this.ColorBlendFunction != this.AlphaBlendFunction)
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoSeparateAlphaBlend, (object) "ColorBlendFunction", (object) "AlphaBlendFunction");
      }
      if (!profileCapabilities.DestBlendSrcAlphaSat)
      {
        if (this.ColorDestinationBlend == Blend.SourceAlphaSaturation)
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileFeatureNotSupported, (object) "ColorDestinationBlend = Blend.SourceAlphaSaturation");
        if (this.AlphaDestinationBlend == Blend.SourceAlphaSaturation)
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileFeatureNotSupported, (object) "AlphaDestinationBlend = Blend.SourceAlphaSaturation");
      }
      if (!profileCapabilities.MinMaxSrcDestBlend)
      {
        if ((this.ColorBlendFunction == BlendFunction.Min || this.ColorBlendFunction == BlendFunction.Max) && (this.ColorSourceBlend != Blend.One || this.ColorDestinationBlend != Blend.One))
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoMinMaxSrcDestBlend, (object) "Color");
        if ((this.AlphaBlendFunction == BlendFunction.Min || this.AlphaBlendFunction == BlendFunction.Max) && (this.AlphaSourceBlend != Blend.One || this.AlphaDestinationBlend != Blend.One))
          profileCapabilities.ThrowNotSupportedException(FrameworkResources.ProfileNoMinMaxSrcDestBlend, (object) "Alpha");
      }
      this.Unbind();
      BlendState.Settings settings = this.settings;
      settings.AlphaSourceBlend = GraphicsHelpers.AdjustAlphaBlend(settings.AlphaSourceBlend);
      settings.AlphaDestinationBlend = GraphicsHelpers.AdjustAlphaBlend(settings.AlphaDestinationBlend);
      this.pComPtr = UnsafeNativeMethods.Device.GetGlobal(this._parent).CreateBlendState(device.pComPtr, ref settings);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = device;
      this.isBound = true;
    }

    private void Unbind()
    {
      if (this.pComPtr == uint.MaxValue)
        return;
      UnsafeNativeMethods.Device.GetGlobal(this._parent).ReleaseBlendState(this.pComPtr);
      this.pComPtr = uint.MaxValue;
    }

    private void ThrowIfBound()
    {
      if (this.isBound)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.BoundStateObject, (object) typeof (BlendState).Name));
    }

    static BlendState()
    {
      BlendState blendState1 = new BlendState();
      blendState1.Name = "BlendState.Opaque";
      blendState1.ColorSourceBlend = Blend.One;
      blendState1.AlphaSourceBlend = Blend.One;
      blendState1.ColorDestinationBlend = Blend.Zero;
      blendState1.AlphaDestinationBlend = Blend.Zero;
      blendState1.isBound = true;
      BlendState.Opaque = blendState1;
      BlendState blendState2 = new BlendState();
      blendState2.Name = "BlendState.AlphaBlend";
      blendState2.ColorSourceBlend = Blend.One;
      blendState2.AlphaSourceBlend = Blend.One;
      blendState2.ColorDestinationBlend = Blend.InverseSourceAlpha;
      blendState2.AlphaDestinationBlend = Blend.InverseSourceAlpha;
      blendState2.isBound = true;
      BlendState.AlphaBlend = blendState2;
      BlendState blendState3 = new BlendState();
      blendState3.Name = "BlendState.Additive";
      blendState3.ColorSourceBlend = Blend.SourceAlpha;
      blendState3.AlphaSourceBlend = Blend.SourceAlpha;
      blendState3.ColorDestinationBlend = Blend.One;
      blendState3.AlphaDestinationBlend = Blend.One;
      blendState3.isBound = true;
      BlendState.Additive = blendState3;
      BlendState blendState4 = new BlendState();
      blendState4.Name = "BlendState.NonPremultiplied";
      blendState4.ColorSourceBlend = Blend.SourceAlpha;
      blendState4.AlphaSourceBlend = Blend.SourceAlpha;
      blendState4.ColorDestinationBlend = Blend.InverseSourceAlpha;
      blendState4.AlphaDestinationBlend = Blend.InverseSourceAlpha;
      blendState4.isBound = true;
      BlendState.NonPremultiplied = blendState4;
    }

    internal struct Settings
    {
      internal Blend ColorSourceBlend;
      internal Blend ColorDestinationBlend;
      internal BlendFunction ColorBlendFunction;
      internal Blend AlphaSourceBlend;
      internal Blend AlphaDestinationBlend;
      internal BlendFunction AlphaBlendFunction;
      internal ColorWriteChannels ColorWriteChannels;
      internal ColorWriteChannels ColorWriteChannels1;
      internal ColorWriteChannels ColorWriteChannels2;
      internal ColorWriteChannels ColorWriteChannels3;
      internal Color BlendFactor;
      internal int MultiSampleMask;
    }
  }
}
