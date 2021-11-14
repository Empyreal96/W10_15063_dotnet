// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.AdvertisingManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [Static(typeof (IAdvertisingManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Static(typeof (IAdvertisingManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class AdvertisingManager
  {
    [MethodImpl]
    public static extern AdvertisingManagerForUser GetForUser(User user);

    public static extern string AdvertisingId { [MethodImpl] get; }
  }
}
