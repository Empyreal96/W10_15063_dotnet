// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Print3DTaskRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [Muse(Version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class Print3DTaskRequest : IPrint3DTaskRequest
  {
    [MethodImpl]
    public extern Print3DTask CreateTask(
      string title,
      string printerId,
      Print3DTaskSourceRequestedHandler handler);
  }
}
