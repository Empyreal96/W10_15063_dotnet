// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Profile.RetailMode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Profile
{
  [Static(typeof (IRetailModeStatics), 65536, "Windows.Phone.PhoneContract")]
  [Deprecated("Use Windows.System.Profile.RetailInfo instead.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public static class RetailMode
  {
    public static extern bool RetailModeEnabled { [Deprecated("Use Windows.System.Profile.IRetailInfoStatics instead.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneContract"), MethodImpl] get; }
  }
}
