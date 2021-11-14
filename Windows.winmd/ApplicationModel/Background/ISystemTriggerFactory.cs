// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISystemTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SystemTrigger))]
  [Guid(3892585428, 34705, 17785, 129, 38, 135, 236, 138, 170, 64, 122)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemTriggerFactory
  {
    SystemTrigger Create(SystemTriggerType triggerType, bool oneShot);
  }
}
