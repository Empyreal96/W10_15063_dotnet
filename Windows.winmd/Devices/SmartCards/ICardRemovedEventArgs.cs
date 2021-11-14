// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ICardRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(355670703, 8919, 18757, 175, 201, 3, 180, 111, 66, 166, 205)]
  [ExclusiveTo(typeof (CardRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICardRemovedEventArgs
  {
    SmartCard SmartCard { get; }
  }
}
