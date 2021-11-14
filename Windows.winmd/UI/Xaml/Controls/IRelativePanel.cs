// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRelativePanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(783022827, 45914, 16437, 172, 234, 60, 74, 55, 48, 104, 63)]
  [ExclusiveTo(typeof (RelativePanel))]
  internal interface IRelativePanel
  {
    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }
  }
}
