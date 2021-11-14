// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ClosestInteractiveBoundsRequestedEventArgs : 
    IClosestInteractiveBoundsRequestedEventArgs
  {
    public extern Point PointerPosition { [MethodImpl] get; }

    public extern Rect SearchBounds { [MethodImpl] get; }

    public extern Rect ClosestInteractiveBounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
