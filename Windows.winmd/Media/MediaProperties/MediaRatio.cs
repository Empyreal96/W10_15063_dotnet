// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaRatio
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaRatio : IMediaRatio
  {
    public extern uint Numerator { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Denominator { [MethodImpl] set; [MethodImpl] get; }
  }
}
