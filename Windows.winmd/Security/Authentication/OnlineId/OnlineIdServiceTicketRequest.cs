// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IOnlineIdServiceTicketRequestFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OnlineIdServiceTicketRequest : IOnlineIdServiceTicketRequest
  {
    [MethodImpl]
    public extern OnlineIdServiceTicketRequest(string service, string policy);

    [MethodImpl]
    public extern OnlineIdServiceTicketRequest(string service);

    public extern string Service { [MethodImpl] get; }

    public extern string Policy { [MethodImpl] get; }
  }
}
