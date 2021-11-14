// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationDataStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (ApplicationData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3445645841, 53065, 16548, 164, 124, 199, 240, 219, 186, 129, 7)]
  internal interface IApplicationDataStatics2
  {
    [RemoteAsync]
    IAsyncOperation<ApplicationData> GetForUserAsync(User user);
  }
}
