// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreDispatcherWithTaskPriority
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3137006765, 18509, 16830, 186, 128, 29, 88, 198, 82, 99, 234)]
  [ExclusiveTo(typeof (CoreDispatcher))]
  internal interface ICoreDispatcherWithTaskPriority
  {
    CoreDispatcherPriority CurrentPriority { get; set; }

    [Overload("ShouldYield")]
    bool ShouldYield();

    [Overload("ShouldYieldToPriority")]
    bool ShouldYield(CoreDispatcherPriority priority);

    void StopProcessEvents();
  }
}
