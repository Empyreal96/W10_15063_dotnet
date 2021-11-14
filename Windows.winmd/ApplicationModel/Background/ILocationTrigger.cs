// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ILocationTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (LocationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1197894172, 26743, 18462, 128, 38, 255, 126, 20, 168, 17, 160)]
  internal interface ILocationTrigger : IBackgroundTrigger
  {
    LocationTriggerType TriggerType { get; }
  }
}
