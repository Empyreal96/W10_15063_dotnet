// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAllJoynAcceptSessionJoinerEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class AllJoynAcceptSessionJoinerEventArgs : IAllJoynAcceptSessionJoinerEventArgs
  {
    [MethodImpl]
    public extern AllJoynAcceptSessionJoinerEventArgs(
      string uniqueName,
      ushort sessionPort,
      AllJoynTrafficType trafficType,
      byte proximity,
      IAllJoynAcceptSessionJoiner acceptSessionJoiner);

    public extern string UniqueName { [MethodImpl] get; }

    public extern ushort SessionPort { [MethodImpl] get; }

    public extern AllJoynTrafficType TrafficType { [MethodImpl] get; }

    public extern bool SamePhysicalNode { [MethodImpl] get; }

    public extern bool SameNetwork { [MethodImpl] get; }

    [MethodImpl]
    public extern void Accept();
  }
}
