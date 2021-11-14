// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Analytics.HostInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Analytics
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHostInformationStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public static class HostInformation
  {
    public static extern string PublisherHostId { [MethodImpl] get; }
  }
}
