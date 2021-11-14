// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ExclusiveTo(typeof (AppServiceTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2292374700, 44328, 16824, 128, 187, 189, 241, 178, 22, 158, 25)]
  internal interface IAppServiceTriggerDetails
  {
    string Name { get; }

    string CallerPackageFamilyName { get; }

    AppServiceConnection AppServiceConnection { get; }
  }
}
