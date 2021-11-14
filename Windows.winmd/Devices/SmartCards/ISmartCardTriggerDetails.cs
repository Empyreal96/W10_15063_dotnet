// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(1604055326, 14831, 20267, 180, 79, 10, 145, 85, 177, 119, 188)]
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 65536)]
  [ExclusiveTo(typeof (SmartCardTriggerDetails))]
  internal interface ISmartCardTriggerDetails
  {
    SmartCardTriggerType TriggerType { get; }

    IBuffer SourceAppletId { get; }

    IBuffer TriggerData { get; }
  }
}
