// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IProgressBarStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProgressBar))]
  [WebHostHidden]
  [Guid(2048040922, 22583, 20006, 179, 180, 225, 192, 146, 206, 187, 236)]
  internal interface IProgressBarStatics
  {
    DependencyProperty IsIndeterminateProperty { get; }

    DependencyProperty ShowErrorProperty { get; }

    DependencyProperty ShowPausedProperty { get; }
  }
}
