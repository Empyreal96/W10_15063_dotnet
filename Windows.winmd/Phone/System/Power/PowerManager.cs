// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.Power.PowerManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.Power
{
  [Static(typeof (IPowerManagerStatics), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Static(typeof (IPowerManagerStatics2), 65536, "Windows.Phone.PhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class PowerManager
  {
    public static extern PowerSavingMode PowerSavingMode { [MethodImpl] get; }

    public static extern event EventHandler<object> PowerSavingModeChanged;

    public static extern bool PowerSavingModeEnabled { [MethodImpl] get; }
  }
}
