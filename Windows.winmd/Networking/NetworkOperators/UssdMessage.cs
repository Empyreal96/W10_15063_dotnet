// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UssdMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IUssdMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class UssdMessage : IUssdMessage
  {
    [MethodImpl]
    public extern UssdMessage(string messageText);

    public extern byte DataCodingScheme { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern byte[] GetPayload();

    [MethodImpl]
    public extern void SetPayload([Range(0, 160)] byte[] value);

    public extern string PayloadAsText { [MethodImpl] get; [MethodImpl] set; }
  }
}
