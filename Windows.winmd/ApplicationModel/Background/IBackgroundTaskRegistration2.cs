// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistration2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1631110915, 48006, 16658, 175, 195, 127, 147, 155, 22, 110, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTaskRegistration2 : IBackgroundTaskRegistration
  {
    IBackgroundTrigger Trigger { get; }
  }
}
