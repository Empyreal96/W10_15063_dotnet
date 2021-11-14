// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GraphicsDeviceInformation
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework
{
  public class GraphicsDeviceInformation
  {
    private PresentationParameters presentationParameters = new PresentationParameters();
    private GraphicsAdapter adapter = GraphicsAdapter.DefaultAdapter;
    private GraphicsProfile graphicsProfile;

    public GraphicsAdapter Adapter
    {
      get => this.adapter;
      set => this.adapter = this.adapter != null ? value : throw new ArgumentNullException(nameof (value), Resources.NoNullUseDefaultAdapter);
    }

    public GraphicsProfile GraphicsProfile
    {
      get => this.graphicsProfile;
      set => this.graphicsProfile = value;
    }

    public PresentationParameters PresentationParameters
    {
      get => this.presentationParameters;
      set => this.presentationParameters = value;
    }

    public override bool Equals(object obj) => obj is GraphicsDeviceInformation deviceInformation && deviceInformation.adapter.Equals((object) this.adapter) && (deviceInformation.graphicsProfile.Equals((object) this.graphicsProfile) && deviceInformation.PresentationParameters.BackBufferWidth == this.PresentationParameters.BackBufferWidth) && (deviceInformation.PresentationParameters.BackBufferHeight == this.PresentationParameters.BackBufferHeight && deviceInformation.PresentationParameters.BackBufferFormat == this.PresentationParameters.BackBufferFormat && (deviceInformation.PresentationParameters.DepthStencilFormat == this.PresentationParameters.DepthStencilFormat && deviceInformation.PresentationParameters.MultiSampleCount == this.PresentationParameters.MultiSampleCount)) && (deviceInformation.PresentationParameters.DisplayOrientation == this.PresentationParameters.DisplayOrientation && deviceInformation.PresentationParameters.PresentationInterval == this.PresentationParameters.PresentationInterval && (deviceInformation.PresentationParameters.RenderTargetUsage == this.PresentationParameters.RenderTargetUsage && !(deviceInformation.PresentationParameters.DeviceWindowHandle != this.PresentationParameters.DeviceWindowHandle)) && deviceInformation.PresentationParameters.IsFullScreen == this.PresentationParameters.IsFullScreen);

    public override int GetHashCode() => this.graphicsProfile.GetHashCode() ^ this.adapter.GetHashCode() ^ this.presentationParameters.BackBufferWidth.GetHashCode() ^ this.presentationParameters.BackBufferHeight.GetHashCode() ^ this.presentationParameters.BackBufferFormat.GetHashCode() ^ this.presentationParameters.DepthStencilFormat.GetHashCode() ^ this.presentationParameters.MultiSampleCount.GetHashCode() ^ this.presentationParameters.DisplayOrientation.GetHashCode() ^ this.presentationParameters.PresentationInterval.GetHashCode() ^ this.presentationParameters.RenderTargetUsage.GetHashCode() ^ this.presentationParameters.DeviceWindowHandle.GetHashCode() ^ this.presentationParameters.IsFullScreen.GetHashCode();

    public GraphicsDeviceInformation Clone() => new GraphicsDeviceInformation()
    {
      presentationParameters = this.presentationParameters.Clone(),
      adapter = this.adapter,
      graphicsProfile = this.graphicsProfile
    };
  }
}
