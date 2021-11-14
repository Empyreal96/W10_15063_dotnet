// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarHelpers
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class AvatarHelpers
  {
    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal static GraphicsDevice GraphicsDevice
    {
      get
      {
        if (!GamerServicesDispatcher.IsInitialized)
          throw new InvalidOperationException(FrameworkResources.GamerServicesNotInitialized);
        IGraphicsDeviceService service = (IGraphicsDeviceService) GamerServicesDispatcher.serviceProvider.GetService(typeof (IGraphicsDeviceService));
        if (service == null)
          throw new InvalidOperationException(FrameworkResources.NoGraphicsDevice);
        return service.GraphicsDevice != null ? service.GraphicsDevice : throw new InvalidOperationException(FrameworkResources.NoGraphicsDevice);
      }
    }
  }
}
