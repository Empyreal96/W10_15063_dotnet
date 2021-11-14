// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISmartCardTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.SmartCards;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SmartCardTrigger))]
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 65536)]
  [Guid(1673483459, 35265, 19968, 169, 211, 151, 198, 41, 38, 157, 173)]
  internal interface ISmartCardTriggerFactory
  {
    SmartCardTrigger Create(SmartCardTriggerType triggerType);
  }
}
