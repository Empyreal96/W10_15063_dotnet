// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardConnection))]
  [Guid(2128320794, 43034, 18364, 166, 73, 21, 107, 230, 183, 242, 49)]
  internal interface ISmartCardConnection : IClosable
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> TransmitAsync(IBuffer command);
  }
}
