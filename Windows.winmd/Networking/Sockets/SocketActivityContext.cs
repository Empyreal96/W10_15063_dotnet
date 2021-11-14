// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISocketActivityContextFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class SocketActivityContext : ISocketActivityContext
  {
    [MethodImpl]
    public extern SocketActivityContext(IBuffer data);

    public extern IBuffer Data { [MethodImpl] get; }
  }
}
