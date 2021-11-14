// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceResponse
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2370845932, 39587, 20072, 149, 89, 157, 230, 62, 55, 44, 228)]
  [ExclusiveTo(typeof (AppServiceResponse))]
  internal interface IAppServiceResponse
  {
    ValueSet Message { get; }

    AppServiceResponseStatus Status { get; }
  }
}
