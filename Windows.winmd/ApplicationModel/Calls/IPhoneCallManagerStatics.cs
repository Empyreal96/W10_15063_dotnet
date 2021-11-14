// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Guid(1626188920, 30886, 18546, 163, 239, 152, 50, 94, 200, 184, 67)]
  [ExclusiveTo(typeof (PhoneCallManager))]
  internal interface IPhoneCallManagerStatics
  {
    void ShowPhoneCallUI(string phoneNumber, string displayName);
  }
}
