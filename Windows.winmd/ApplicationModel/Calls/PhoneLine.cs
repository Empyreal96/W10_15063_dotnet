// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneLine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Calls
{
  [Static(typeof (IPhoneLineStatics), 65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  public sealed class PhoneLine : IPhoneLine
  {
    public extern event TypedEventHandler<PhoneLine, object> LineChanged;

    public extern Guid Id { [MethodImpl] get; }

    public extern Color DisplayColor { [MethodImpl] get; }

    public extern PhoneNetworkState NetworkState { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern PhoneVoicemail Voicemail { [MethodImpl] get; }

    public extern string NetworkName { [MethodImpl] get; }

    public extern PhoneLineCellularDetails CellularDetails { [MethodImpl] get; }

    public extern PhoneLineTransport Transport { [MethodImpl] get; }

    public extern bool CanDial { [MethodImpl] get; }

    public extern bool SupportsTile { [MethodImpl] get; }

    public extern PhoneCallVideoCapabilities VideoCallingCapabilities { [MethodImpl] get; }

    public extern PhoneLineConfiguration LineConfiguration { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsImmediateDialNumberAsync(string number);

    [MethodImpl]
    public extern void Dial(string number, string displayName);

    [MethodImpl]
    public extern void DialWithOptions(PhoneDialOptions options);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhoneLine> FromIdAsync(Guid lineId);
  }
}
