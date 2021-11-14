// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(3579647350, 27090, 21299, 91, 95, 248, 192, 214, 233, 240, 159)]
  [ExclusiveTo(typeof (SmartCardEmulatorApduReceivedEventArgs))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  internal interface ISmartCardEmulatorApduReceivedEventArgs
  {
    IBuffer CommandApdu { get; }

    SmartCardEmulatorConnectionProperties ConnectionProperties { get; }

    [RemoteAsync]
    IAsyncOperation<bool> TryRespondAsync(IBuffer responseApdu);

    SmartCardAutomaticResponseStatus AutomaticResponseStatus { get; }
  }
}
