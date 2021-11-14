// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IAdaptiveTriggerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AdaptiveTrigger))]
  [Guid(3106810346, 5653, 17232, 156, 59, 146, 178, 152, 107, 244, 68)]
  internal interface IAdaptiveTriggerStatics
  {
    DependencyProperty MinWindowWidthProperty { get; }

    DependencyProperty MinWindowHeightProperty { get; }
  }
}
