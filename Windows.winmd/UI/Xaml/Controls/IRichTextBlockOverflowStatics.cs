// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockOverflowStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(68862711, 20267, 17347, 161, 34, 63, 234, 156, 169, 220, 135)]
  [ExclusiveTo(typeof (RichTextBlockOverflow))]
  internal interface IRichTextBlockOverflowStatics
  {
    DependencyProperty OverflowContentTargetProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty HasOverflowContentProperty { get; }
  }
}
