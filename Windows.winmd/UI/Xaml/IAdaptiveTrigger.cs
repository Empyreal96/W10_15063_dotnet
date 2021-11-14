// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IAdaptiveTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2783985945, 3289, 18929, 162, 63, 68, 229, 71, 171, 159, 26)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdaptiveTrigger))]
  [WebHostHidden]
  internal interface IAdaptiveTrigger
  {
    double MinWindowWidth { get; set; }

    double MinWindowHeight { get; set; }
  }
}
