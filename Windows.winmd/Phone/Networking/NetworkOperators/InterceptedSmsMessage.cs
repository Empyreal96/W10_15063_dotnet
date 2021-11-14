// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.InterceptedSmsMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class InterceptedSmsMessage : IInterceptedSmsMessage
  {
    public extern string Body { [MethodImpl] get; }

    public extern string SenderPhoneNumber { [MethodImpl] get; }

    public extern string ProductId { [MethodImpl] get; }

    public extern string SmsPrefix { [MethodImpl] get; }

    public extern DateTime TimeStamp { [MethodImpl] get; }
  }
}
