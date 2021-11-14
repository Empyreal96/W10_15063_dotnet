// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [Guid(2115719970, 60080, 16968, 174, 4, 253, 249, 56, 56, 228, 114)]
  [ExclusiveTo(typeof (AppServiceDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppServiceDeferral
  {
    void Complete();
  }
}
