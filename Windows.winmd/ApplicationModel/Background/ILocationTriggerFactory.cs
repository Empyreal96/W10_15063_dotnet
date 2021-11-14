// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ILocationTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (LocationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(285653767, 65385, 19977, 170, 139, 19, 132, 234, 71, 94, 152)]
  internal interface ILocationTriggerFactory
  {
    LocationTrigger Create(LocationTriggerType triggerType);
  }
}
