// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ITimeTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (TimeTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1701729622, 2858, 17271, 186, 112, 59, 69, 169, 53, 84, 127)]
  internal interface ITimeTrigger : IBackgroundTrigger
  {
    uint FreshnessTime { get; }

    bool OneShot { get; }
  }
}
