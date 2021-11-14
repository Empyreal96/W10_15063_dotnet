// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceClosedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3730839286, 51971, 19765, 172, 141, 204, 99, 3, 35, 151, 49)]
  [ExclusiveTo(typeof (AppServiceClosedEventArgs))]
  internal interface IAppServiceClosedEventArgs
  {
    AppServiceClosedStatus Status { get; }
  }
}
