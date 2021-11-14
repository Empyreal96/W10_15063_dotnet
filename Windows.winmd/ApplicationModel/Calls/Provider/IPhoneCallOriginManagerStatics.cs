// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.IPhoneCallOriginManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Provider
{
  [ExclusiveTo(typeof (PhoneCallOriginManager))]
  [Guid(3439090186, 39671, 24905, 57, 208, 224, 118, 252, 206, 19, 149)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  internal interface IPhoneCallOriginManagerStatics
  {
    bool IsCurrentAppActiveCallOriginApp { get; }

    void ShowPhoneCallOriginSettingsUI();

    void SetCallOrigin(Guid requestId, PhoneCallOrigin callOrigin);
  }
}
