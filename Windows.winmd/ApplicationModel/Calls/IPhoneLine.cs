// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneLine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [ExclusiveTo(typeof (PhoneLine))]
  [Guid(667316016, 27241, 13514, 162, 186, 101, 48, 37, 48, 195, 17)]
  internal interface IPhoneLine
  {
    event TypedEventHandler<PhoneLine, object> LineChanged;

    Guid Id { get; }

    Color DisplayColor { get; }

    PhoneNetworkState NetworkState { get; }

    string DisplayName { get; }

    PhoneVoicemail Voicemail { get; }

    string NetworkName { get; }

    PhoneLineCellularDetails CellularDetails { get; }

    PhoneLineTransport Transport { get; }

    bool CanDial { get; }

    bool SupportsTile { get; }

    PhoneCallVideoCapabilities VideoCallingCapabilities { get; }

    PhoneLineConfiguration LineConfiguration { get; }

    [RemoteAsync]
    IAsyncOperation<bool> IsImmediateDialNumberAsync(string number);

    void Dial(string number, string displayName);

    void DialWithOptions(PhoneDialOptions options);
  }
}
