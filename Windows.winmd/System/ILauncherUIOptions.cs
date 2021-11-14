// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherUIOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.System
{
  [ExclusiveTo(typeof (LauncherUIOptions))]
  [Guid(455465582, 35494, 16873, 130, 81, 65, 101, 245, 152, 95, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILauncherUIOptions
  {
    IReference<Point> InvocationPoint { get; set; }

    IReference<Rect> SelectionRect { get; set; }

    Placement PreferredPlacement { get; set; }
  }
}
