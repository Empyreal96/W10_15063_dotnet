// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISmartCardTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.SmartCards;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SmartCardTrigger))]
  [Guid(4114335148, 33994, 18802, 140, 233, 229, 143, 151, 179, 122, 80)]
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 65536)]
  internal interface ISmartCardTrigger : IBackgroundTrigger
  {
    SmartCardTriggerType TriggerType { get; }
  }
}
