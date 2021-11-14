// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Print3DTaskCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Print3DTaskCompletedEventArgs : IPrint3DTaskCompletedEventArgs
  {
    public extern Print3DTaskCompletion Completion { [MethodImpl] get; }

    public extern Print3DTaskDetail ExtendedStatus { [MethodImpl] get; }
  }
}
