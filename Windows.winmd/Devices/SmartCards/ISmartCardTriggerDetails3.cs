// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardTriggerDetails3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 196608)]
  [ExclusiveTo(typeof (SmartCardTriggerDetails))]
  [Guid(3017982589, 6342, 19368, 131, 118, 239, 3, 212, 145, 38, 102)]
  internal interface ISmartCardTriggerDetails3
  {
    SmartCard SmartCard { get; }
  }
}
