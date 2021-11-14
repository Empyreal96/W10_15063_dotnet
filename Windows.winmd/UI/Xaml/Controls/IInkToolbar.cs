// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1037896906, 20976, 18543, 160, 62, 78, 225, 61, 193, 43, 203)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbar))]
  internal interface IInkToolbar
  {
    InkToolbarInitialControls InitialControls { get; set; }

    DependencyObjectCollection Children { get; }

    InkToolbarToolButton ActiveTool { get; set; }

    InkDrawingAttributes InkDrawingAttributes { get; }

    bool IsRulerButtonChecked { get; set; }

    InkCanvas TargetInkCanvas { get; set; }

    event TypedEventHandler<InkToolbar, object> ActiveToolChanged;

    event TypedEventHandler<InkToolbar, object> InkDrawingAttributesChanged;

    event TypedEventHandler<InkToolbar, object> EraseAllClicked;

    event TypedEventHandler<InkToolbar, object> IsRulerButtonCheckedChanged;

    InkToolbarToolButton GetToolButton(InkToolbarTool tool);

    InkToolbarToggleButton GetToggleButton(InkToolbarToggle tool);
  }
}
