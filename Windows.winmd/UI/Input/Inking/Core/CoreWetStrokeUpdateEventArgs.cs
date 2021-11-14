// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CoreWetStrokeUpdateEventArgs : ICoreWetStrokeUpdateEventArgs
  {
    public extern IVector<InkPoint> NewInkPoints { [MethodImpl] get; }

    public extern uint PointerId { [MethodImpl] get; }

    public extern CoreWetStrokeDisposition Disposition { [MethodImpl] get; [MethodImpl] set; }
  }
}
