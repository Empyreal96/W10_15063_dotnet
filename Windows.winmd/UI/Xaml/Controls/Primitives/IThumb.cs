// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IThumb
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Thumb))]
  [WebHostHidden]
  [Guid(3904025217, 3434, 17871, 179, 51, 36, 2, 176, 55, 240, 153)]
  internal interface IThumb
  {
    bool IsDragging { get; }

    event DragStartedEventHandler DragStarted;

    event DragDeltaEventHandler DragDelta;

    event DragCompletedEventHandler DragCompleted;

    void CancelDrag();
  }
}
