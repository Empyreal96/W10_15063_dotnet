// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Print3DTaskRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Print3DTaskRequestedEventArgs : IPrint3DTaskRequestedEventArgs
  {
    public extern Print3DTaskRequest Request { [MethodImpl] get; }
  }
}
