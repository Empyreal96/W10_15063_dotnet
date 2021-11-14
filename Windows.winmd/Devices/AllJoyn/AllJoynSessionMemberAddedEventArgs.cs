// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSessionMemberAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAllJoynSessionMemberAddedEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynSessionMemberAddedEventArgs : IAllJoynSessionMemberAddedEventArgs
  {
    [MethodImpl]
    public extern AllJoynSessionMemberAddedEventArgs(string uniqueName);

    public extern string UniqueName { [MethodImpl] get; }
  }
}
