// Decompiled with JetBrains decompiler
// Type: Windows.Networking.EndpointPair
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IEndpointPairFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EndpointPair : IEndpointPair
  {
    [MethodImpl]
    public extern EndpointPair(
      HostName localHostName,
      string localServiceName,
      HostName remoteHostName,
      string remoteServiceName);

    public extern HostName LocalHostName { [MethodImpl] get; [MethodImpl] set; }

    public extern string LocalServiceName { [MethodImpl] get; [MethodImpl] set; }

    public extern HostName RemoteHostName { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteServiceName { [MethodImpl] get; [MethodImpl] set; }
  }
}
