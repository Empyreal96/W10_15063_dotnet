// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallVideoCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallVideoCapabilities))]
  [Guid(37234566, 45418, 20443, 190, 59, 196, 36, 14, 19, 173, 13)]
  internal interface IPhoneCallVideoCapabilities
  {
    bool IsVideoCallingCapable { get; }
  }
}
