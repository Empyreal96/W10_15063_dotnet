// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPathIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(558654171, 50022, 18958, 185, 173, 220, 241, 104, 215, 236, 12)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PathIcon))]
  internal interface IPathIcon
  {
    Geometry Data { get; set; }
  }
}
