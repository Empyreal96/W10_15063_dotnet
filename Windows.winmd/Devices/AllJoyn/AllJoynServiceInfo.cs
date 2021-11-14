// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynServiceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Static(typeof (IAllJoynServiceInfoStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IAllJoynServiceInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynServiceInfo : IAllJoynServiceInfo
  {
    [MethodImpl]
    public extern AllJoynServiceInfo(string uniqueName, string objectPath, ushort sessionPort);

    public extern string UniqueName { [MethodImpl] get; }

    public extern string ObjectPath { [MethodImpl] get; }

    public extern ushort SessionPort { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynServiceInfo> FromIdAsync(
      string deviceId);
  }
}
