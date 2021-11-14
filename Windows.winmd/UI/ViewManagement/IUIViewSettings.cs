// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUIViewSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3325450230, 34896, 18189, 136, 248, 69, 94, 22, 234, 44, 38)]
  [ExclusiveTo(typeof (UIViewSettings))]
  internal interface IUIViewSettings
  {
    UserInteractionMode UserInteractionMode { get; }
  }
}
