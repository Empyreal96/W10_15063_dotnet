// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2725106140, 52548, 17244, 190, 148, 1, 214, 36, 28, 35, 28)]
  [ExclusiveTo(typeof (ContentControl))]
  [WebHostHidden]
  internal interface IContentControl
  {
    object Content { get; set; }

    DataTemplate ContentTemplate { get; set; }

    DataTemplateSelector ContentTemplateSelector { get; set; }

    TransitionCollection ContentTransitions { get; set; }
  }
}
