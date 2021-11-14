// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDebugSettings3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DebugSettings))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3871035426, 1573, 18335, 142, 50, 75, 88, 61, 115, 183, 172)]
  internal interface IDebugSettings3
  {
    bool IsTextPerformanceVisualizationEnabled { get; set; }
  }
}
