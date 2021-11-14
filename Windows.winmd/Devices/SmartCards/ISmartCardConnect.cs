// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardConnect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(803178469, 653, 18718, 160, 88, 51, 130, 195, 152, 111, 64)]
  [ExclusiveTo(typeof (SmartCard))]
  internal interface ISmartCardConnect
  {
    [RemoteAsync]
    IAsyncOperation<SmartCardConnection> ConnectAsync();
  }
}
