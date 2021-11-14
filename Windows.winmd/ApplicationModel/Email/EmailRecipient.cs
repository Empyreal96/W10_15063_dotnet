// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailRecipient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IEmailRecipientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EmailRecipient : IEmailRecipient
  {
    [MethodImpl]
    public extern EmailRecipient(string address);

    [MethodImpl]
    public extern EmailRecipient(string address, string name);

    [MethodImpl]
    public extern EmailRecipient();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Address { [MethodImpl] get; [MethodImpl] set; }
  }
}
