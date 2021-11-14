// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IProgressBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2926914697, 103, 18787, 191, 76, 41, 219, 12, 74, 80, 126)]
  [ExclusiveTo(typeof (ProgressBar))]
  internal interface IProgressBar
  {
    bool IsIndeterminate { get; set; }

    bool ShowError { get; set; }

    bool ShowPaused { get; set; }

    ProgressBarTemplateSettings TemplateSettings { get; }
  }
}
