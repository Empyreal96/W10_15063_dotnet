// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkSynchronizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  [WebHostHidden]
  [DualApiPartition(version = 167772160)]
  public sealed class InkSynchronizer : IInkSynchronizer
  {
    [MethodImpl]
    public extern IVectorView<InkStroke> BeginDry();

    [MethodImpl]
    public extern void EndDry();
  }
}
