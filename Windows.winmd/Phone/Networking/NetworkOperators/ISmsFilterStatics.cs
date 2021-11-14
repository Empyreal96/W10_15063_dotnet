// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.ISmsFilterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [Guid(2172264039, 5462, 20324, 144, 210, 153, 226, 245, 85, 8, 17)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SmsFilter))]
  internal interface ISmsFilterStatics
  {
    void EnableFiltering(bool enableSmsFiltering);

    SmsFilterStatus Status { get; }

    event EventHandler<SmsFilterMessageReceivedEventArgs> SmsMessageReceived;

    event EventHandler<object> StatusChanged;
  }
}
