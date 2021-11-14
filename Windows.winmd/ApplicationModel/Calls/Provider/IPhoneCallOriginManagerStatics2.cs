// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.IPhoneCallOriginManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Provider
{
  [ExclusiveTo(typeof (PhoneCallOriginManager))]
  [Guid(2348019263, 16628, 17280, 140, 124, 174, 162, 201, 184, 221, 122)]
  [ContractVersion(typeof (CallsPhoneContract), 196608)]
  internal interface IPhoneCallOriginManagerStatics2 : IPhoneCallOriginManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> RequestSetAsActiveCallOriginAppAsync();
  }
}
