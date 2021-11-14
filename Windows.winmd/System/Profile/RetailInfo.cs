// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.RetailInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (ProfileRetailInfoContract), 65536)]
  [Static(typeof (IRetailInfoStatics), 65536, "Windows.System.Profile.ProfileRetailInfoContract")]
  [Threading(ThreadingModel.Both)]
  public static class RetailInfo
  {
    public static extern bool IsDemoModeEnabled { [MethodImpl] get; }

    public static extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }
  }
}
