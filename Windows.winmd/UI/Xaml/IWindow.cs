// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(846599805, 51702, 17965, 157, 226, 174, 76, 31, 216, 194, 229)]
  [ExclusiveTo(typeof (Window))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWindow
  {
    Rect Bounds { get; }

    bool Visible { get; }

    UIElement Content { get; set; }

    CoreWindow CoreWindow { get; }

    CoreDispatcher Dispatcher { get; }

    event WindowActivatedEventHandler Activated;

    event WindowClosedEventHandler Closed;

    event WindowSizeChangedEventHandler SizeChanged;

    event WindowVisibilityChangedEventHandler VisibilityChanged;

    void Activate();

    void Close();
  }
}
