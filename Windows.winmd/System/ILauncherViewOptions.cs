// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherViewOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2325424625, 31911, 18910, 155, 211, 60, 91, 113, 132, 246, 22)]
  public interface ILauncherViewOptions
  {
    ViewSizePreference DesiredRemainingView { get; set; }
  }
}
