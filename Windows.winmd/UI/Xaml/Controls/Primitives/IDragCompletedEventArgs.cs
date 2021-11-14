// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(2957978017, 48406, 18678, 165, 17, 156, 39, 99, 100, 19, 49)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DragCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragCompletedEventArgs
  {
    double HorizontalChange { get; }

    double VerticalChange { get; }

    bool Canceled { get; }
  }
}
