// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardPinResetRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(318651469, 24505, 20110, 159, 246, 97, 244, 117, 18, 79, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardPinResetRequest))]
  internal interface ISmartCardPinResetRequest
  {
    IBuffer Challenge { get; }

    DateTime Deadline { get; }

    SmartCardPinResetDeferral GetDeferral();

    void SetResponse(IBuffer response);
  }
}
