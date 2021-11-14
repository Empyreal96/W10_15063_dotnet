// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ITimeTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(952533758, 39764, 17894, 178, 243, 38, 155, 135, 166, 247, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimeTrigger))]
  internal interface ITimeTriggerFactory
  {
    TimeTrigger Create(uint freshnessTime, bool oneShot);
  }
}
