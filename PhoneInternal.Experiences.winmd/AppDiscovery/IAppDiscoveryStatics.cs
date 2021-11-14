// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.AppDiscovery.IAppDiscoveryStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.AppDiscovery
{
  [Version(100859904)]
  [ExclusiveTo(typeof (global::PhoneInternal.Experiences.AppDiscovery.AppDiscovery))]
  [Guid(2846023960, 58310, 15657, 153, 234, 37, 90, 79, 204, 203, 61)]
  internal interface IAppDiscoveryStatics
  {
    IAsyncOperation<IVector<IAppData>> GetAppsByExtensionAsync(
      ExtensionID extIdMask);

    IAsyncOperation<IAppData> GetAppByAppIdAsync(Guid appId);
  }
}
