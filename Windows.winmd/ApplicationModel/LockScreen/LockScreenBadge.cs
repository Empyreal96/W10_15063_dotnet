// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockScreenBadge
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LockScreenBadge : ILockScreenBadge
  {
    public extern IRandomAccessStream Logo { [MethodImpl] get; }

    public extern IRandomAccessStream Glyph { [MethodImpl] get; }

    public extern IReference<uint> Number { [MethodImpl] get; }

    public extern string AutomationName { [MethodImpl] get; }

    [MethodImpl]
    public extern void LaunchApp();
  }
}
