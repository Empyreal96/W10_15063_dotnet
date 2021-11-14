// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.H264ProfileIds
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IH264ProfileIdsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class H264ProfileIds
  {
    public static extern int ConstrainedBaseline { [MethodImpl] get; }

    public static extern int Baseline { [MethodImpl] get; }

    public static extern int Extended { [MethodImpl] get; }

    public static extern int Main { [MethodImpl] get; }

    public static extern int High { [MethodImpl] get; }

    public static extern int High10 { [MethodImpl] get; }

    public static extern int High422 { [MethodImpl] get; }

    public static extern int High444 { [MethodImpl] get; }

    public static extern int StereoHigh { [MethodImpl] get; }

    public static extern int MultiviewHigh { [MethodImpl] get; }
  }
}
