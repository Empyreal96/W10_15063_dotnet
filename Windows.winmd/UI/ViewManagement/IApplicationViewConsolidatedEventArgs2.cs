// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewConsolidatedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationViewConsolidatedEventArgs))]
  [Guid(471441100, 28097, 16628, 175, 238, 7, 217, 234, 41, 100, 48)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IApplicationViewConsolidatedEventArgs2
  {
    bool IsAppInitiated { get; }
  }
}
