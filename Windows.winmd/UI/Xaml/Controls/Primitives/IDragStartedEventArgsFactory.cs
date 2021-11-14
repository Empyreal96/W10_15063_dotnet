// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragStartedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1592780153, 50950, 18305, 163, 8, 201, 231, 244, 198, 161, 215)]
  [ExclusiveTo(typeof (DragStartedEventArgs))]
  [WebHostHidden]
  internal interface IDragStartedEventArgsFactory
  {
    DragStartedEventArgs CreateInstanceWithHorizontalOffsetAndVerticalOffset(
      double horizontalOffset,
      double verticalOffset,
      object outer,
      out object inner);
  }
}
