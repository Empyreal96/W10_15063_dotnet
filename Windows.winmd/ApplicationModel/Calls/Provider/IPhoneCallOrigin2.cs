// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Provider.IPhoneCallOrigin2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Provider
{
  [Guid(80210304, 39618, 18280, 181, 54, 182, 141, 164, 149, 125, 2)]
  [ExclusiveTo(typeof (PhoneCallOrigin))]
  [ContractVersion(typeof (CallsPhoneContract), 131072)]
  internal interface IPhoneCallOrigin2 : IPhoneCallOrigin
  {
    string DisplayName { get; set; }
  }
}
