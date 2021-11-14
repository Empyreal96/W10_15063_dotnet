// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DragEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3024144323, 692, 18816, 147, 66, 37, 218, 225, 192, 241, 136)]
  internal interface IDragEventArgs
  {
    bool Handled { get; set; }

    DataPackage Data { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
