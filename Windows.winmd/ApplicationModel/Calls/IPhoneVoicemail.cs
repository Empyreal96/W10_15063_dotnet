// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneVoicemail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(3385751542, 28319, 14987, 183, 39, 110, 12, 246, 153, 130, 36)]
  [ExclusiveTo(typeof (PhoneVoicemail))]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  internal interface IPhoneVoicemail
  {
    string Number { get; }

    int MessageCount { get; }

    PhoneVoicemailType Type { get; }

    [RemoteAsync]
    IAsyncAction DialVoicemailAsync();
  }
}
