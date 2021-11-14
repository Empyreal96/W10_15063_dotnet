// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionMaskBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionMaskBrush : CompositionBrush, ICompositionMaskBrush
  {
    public extern CompositionBrush Mask { [MethodImpl] get; [MethodImpl] set; }

    public extern CompositionBrush Source { [MethodImpl] get; [MethodImpl] set; }
  }
}
