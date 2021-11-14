// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.GraphicsContentHelper
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Content;

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class GraphicsContentHelper
  {
    internal static GraphicsDevice GraphicsDeviceFromContentReader(
      ContentReader contentReader)
    {
      GraphicsDevice graphicsDevice = ((IGraphicsDeviceService) contentReader.ContentManager.ServiceProvider.GetService(typeof (IGraphicsDeviceService)) ?? throw contentReader.CreateContentLoadException(FrameworkResources.NoGraphicsDeviceContent)).GraphicsDevice;
      GraphicsProfile deviceProfile = graphicsDevice != null ? graphicsDevice.GraphicsProfile : throw contentReader.CreateContentLoadException(FrameworkResources.NoGraphicsDeviceContent);
      GraphicsProfile graphicsProfile = (GraphicsProfile) contentReader.graphicsProfile;
      if (!GraphicsContentHelper.IsProfileCompatible(deviceProfile, graphicsProfile))
        throw contentReader.CreateContentLoadException(FrameworkResources.BadXnbGraphicsProfile, (object) graphicsProfile, (object) deviceProfile);
      return graphicsDevice;
    }

    private static bool IsProfileCompatible(
      GraphicsProfile deviceProfile,
      GraphicsProfile contentProfile)
    {
      switch (deviceProfile)
      {
        case GraphicsProfile.Reach:
          return contentProfile == GraphicsProfile.Reach;
        case GraphicsProfile.HiDef:
          return contentProfile == GraphicsProfile.Reach || contentProfile == GraphicsProfile.HiDef;
        default:
          return false;
      }
    }
  }
}
