// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.AppDiscovery
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [Static(typeof (IAppDiscoveryStatics), 100859904)]
  public static class AppDiscovery
  {
    [MethodImpl]
    public static extern IAsyncOperation<IVector<IAppData>> GetAppsByExtensionAsync(
      ExtensionID extIdMask);

    [MethodImpl]
    public static extern IAsyncOperation<IAppData> GetAppByAppIdAsync(
      Guid appId);
  }
}
