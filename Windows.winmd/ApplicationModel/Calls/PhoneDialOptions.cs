// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneDialOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  public sealed class PhoneDialOptions : IPhoneDialOptions
  {
    [MethodImpl]
    public extern PhoneDialOptions();

    public extern string Number { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern Contact Contact { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactPhone ContactPhone { [MethodImpl] get; [MethodImpl] set; }

    public extern PhoneCallMedia Media { [MethodImpl] get; [MethodImpl] set; }

    public extern PhoneAudioRoutingEndpoint AudioEndpoint { [MethodImpl] get; [MethodImpl] set; }
  }
}
