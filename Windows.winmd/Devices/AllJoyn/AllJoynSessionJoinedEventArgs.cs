// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSessionJoinedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IAllJoynSessionJoinedEventArgsFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynSessionJoinedEventArgs : IAllJoynSessionJoinedEventArgs
  {
    [MethodImpl]
    public extern AllJoynSessionJoinedEventArgs(AllJoynSession session);

    public extern AllJoynSession Session { [MethodImpl] get; }
  }
}
