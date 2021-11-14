// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Print3DTaskSourceRequestedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Muse(Version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Print3DTaskSourceRequestedArgs : IPrint3DTaskSourceRequestedArgs
  {
    [MethodImpl]
    public extern void SetSource(Printing3D3MFPackage source);
  }
}
