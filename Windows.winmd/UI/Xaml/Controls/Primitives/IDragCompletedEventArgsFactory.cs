// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragCompletedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(916969885, 5260, 18783, 160, 252, 175, 200, 113, 214, 47, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragCompletedEventArgs))]
  internal interface IDragCompletedEventArgsFactory
  {
    DragCompletedEventArgs CreateInstanceWithHorizontalChangeVerticalChangeAndCanceled(
      double horizontalChange,
      double verticalChange,
      bool canceled,
      object outer,
      out object inner);
  }
}
