// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarHighlighterButtonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarHighlighterButton))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2083736285, 17098, 18755, 148, 164, 35, 181, 166, 229, 92, 241)]
  [WebHostHidden]
  internal interface IInkToolbarHighlighterButtonFactory
  {
    InkToolbarHighlighterButton CreateInstance(
      object outer,
      out object inner);
  }
}
