// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IClosestInteractiveBoundsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(880546263, 63224, 16611, 178, 159, 174, 80, 211, 232, 100, 134)]
  [ExclusiveTo(typeof (ClosestInteractiveBoundsRequestedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IClosestInteractiveBoundsRequestedEventArgs
  {
    Point PointerPosition { get; }

    Rect SearchBounds { get; }

    Rect ClosestInteractiveBounds { get; set; }
  }
}
