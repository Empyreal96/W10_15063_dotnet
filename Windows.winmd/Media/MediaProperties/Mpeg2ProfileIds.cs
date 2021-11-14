// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.Mpeg2ProfileIds
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMpeg2ProfileIdsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class Mpeg2ProfileIds
  {
    public static extern int Simple { [MethodImpl] get; }

    public static extern int Main { [MethodImpl] get; }

    public static extern int SignalNoiseRatioScalable { [MethodImpl] get; }

    public static extern int SpatiallyScalable { [MethodImpl] get; }

    public static extern int High { [MethodImpl] get; }
  }
}
