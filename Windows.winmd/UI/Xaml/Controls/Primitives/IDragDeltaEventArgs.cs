// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IDragDeltaEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(741201724, 10246, 18940, 170, 233, 109, 121, 43, 87, 43, 106)]
  [ExclusiveTo(typeof (DragDeltaEventArgs))]
  [WebHostHidden]
  internal interface IDragDeltaEventArgs
  {
    double HorizontalChange { get; }

    double VerticalChange { get; }
  }
}
