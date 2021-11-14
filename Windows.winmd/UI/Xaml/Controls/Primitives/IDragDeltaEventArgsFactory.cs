// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragDeltaEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (DragDeltaEventArgs))]
  [Guid(1189585391, 44565, 17574, 138, 4, 149, 176, 191, 154, 184, 118)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragDeltaEventArgsFactory
  {
    DragDeltaEventArgs CreateInstanceWithHorizontalChangeAndVerticalChange(
      double horizontalChange,
      double verticalChange,
      object outer,
      out object inner);
  }
}
