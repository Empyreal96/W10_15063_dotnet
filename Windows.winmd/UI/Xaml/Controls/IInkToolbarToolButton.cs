// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarToolButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarToolButton))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1549464606, 52407, 17496, 128, 100, 169, 132, 157, 49, 86, 27)]
  [WebHostHidden]
  internal interface IInkToolbarToolButton
  {
    InkToolbarTool ToolKind { get; }

    bool IsExtensionGlyphShown { get; set; }
  }
}
