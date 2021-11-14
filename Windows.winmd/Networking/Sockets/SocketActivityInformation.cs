// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISocketActivityInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SocketActivityInformation : ISocketActivityInformation
  {
    public extern Guid TaskId { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern SocketActivityKind SocketKind { [MethodImpl] get; }

    public extern SocketActivityContext Context { [MethodImpl] get; }

    public extern DatagramSocket DatagramSocket { [MethodImpl] get; }

    public extern StreamSocket StreamSocket { [MethodImpl] get; }

    public extern StreamSocketListener StreamSocketListener { [MethodImpl] get; }

    public static extern IMapView<string, SocketActivityInformation> AllSockets { [MethodImpl] get; }
  }
}
