// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragUIOverride
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class CoreDragUIOverride : ICoreDragUIOverride
  {
    [Overload("SetContentFromSoftwareBitmap")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(
      SoftwareBitmap softwareBitmap,
      Point anchorPoint);

    public extern bool IsContentVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern string Caption { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCaptionVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsGlyphVisible { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Clear();
  }
}
