// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneVoicemail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  public sealed class PhoneVoicemail : IPhoneVoicemail
  {
    public extern string Number { [MethodImpl] get; }

    public extern int MessageCount { [MethodImpl] get; }

    public extern PhoneVoicemailType Type { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DialVoicemailAsync();
  }
}
