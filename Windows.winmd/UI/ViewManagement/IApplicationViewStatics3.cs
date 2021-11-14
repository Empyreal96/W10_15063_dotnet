// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2727179668, 35905, 19987, 151, 25, 81, 100, 121, 111, 228, 199)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationView))]
  internal interface IApplicationViewStatics3
  {
    ApplicationViewWindowingMode PreferredLaunchWindowingMode { get; set; }

    Size PreferredLaunchViewSize { get; set; }
  }
}
