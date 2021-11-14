// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Print3DTask
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Muse(Version = 167772160)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class Print3DTask : IPrint3DTask
  {
    public extern Printing3D3MFPackage Source { [MethodImpl] get; }

    public extern event TypedEventHandler<Print3DTask, object> Submitting;

    public extern event TypedEventHandler<Print3DTask, Print3DTaskCompletedEventArgs> Completed;

    public extern event TypedEventHandler<Print3DTask, Print3DTaskSourceChangedEventArgs> SourceChanged;
  }
}
