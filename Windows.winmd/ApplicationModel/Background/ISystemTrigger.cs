// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISystemTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(494978934, 14152, 17507, 141, 126, 39, 109, 193, 57, 172, 28)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SystemTrigger))]
  internal interface ISystemTrigger : IBackgroundTrigger
  {
    bool OneShot { get; }

    SystemTriggerType TriggerType { get; }
  }
}
