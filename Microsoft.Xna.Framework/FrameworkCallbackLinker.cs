// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.FrameworkCallbackLinker
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework
{
  internal static class FrameworkCallbackLinker
  {
    internal static event EventHandler StorageDeviceChanged;

    internal static void OnStorageDeviceChanged(EventArgs args)
    {
      EventHandler storageDeviceChanged = FrameworkCallbackLinker.StorageDeviceChanged;
      if (storageDeviceChanged == null)
        return;
      storageDeviceChanged((object) null, args);
    }

    internal static event EventHandler DownloadCompleted;

    internal static void OnDownloadCompleted(EventArgs args)
    {
      EventHandler downloadCompleted = FrameworkCallbackLinker.DownloadCompleted;
      if (downloadCompleted == null)
        return;
      downloadCompleted((object) null, args);
    }

    internal static event EventHandler AvatarChanged;

    internal static void OnAvatarChanged(object sender, EventArgs args)
    {
      EventHandler avatarChanged = FrameworkCallbackLinker.AvatarChanged;
      if (avatarChanged == null)
        return;
      avatarChanged(sender, args);
    }
  }
}
