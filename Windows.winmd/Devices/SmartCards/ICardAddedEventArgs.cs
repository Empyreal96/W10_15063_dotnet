// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ICardAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (CardAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(414969752, 61835, 19923, 177, 24, 223, 178, 200, 226, 60, 198)]
  internal interface ICardAddedEventArgs
  {
    SmartCard SmartCard { get; }
  }
}
