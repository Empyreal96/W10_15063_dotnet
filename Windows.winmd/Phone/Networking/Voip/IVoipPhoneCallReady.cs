// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.IVoipPhoneCallReady
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ExclusiveTo(typeof (VoipPhoneCall))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3019222137, 62479, 20050, 168, 238, 232, 169, 167, 31, 81, 26)]
  internal interface IVoipPhoneCallReady
  {
    void NotifyCallReady();
  }
}
