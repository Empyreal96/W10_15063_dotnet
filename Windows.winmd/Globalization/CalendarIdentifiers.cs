// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.CalendarIdentifiers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Static(typeof (ICalendarIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICalendarIdentifiersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ICalendarIdentifiersStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class CalendarIdentifiers
  {
    public static extern string ChineseLunar { [MethodImpl] get; }

    public static extern string JapaneseLunar { [MethodImpl] get; }

    public static extern string KoreanLunar { [MethodImpl] get; }

    public static extern string TaiwanLunar { [MethodImpl] get; }

    public static extern string VietnameseLunar { [MethodImpl] get; }

    public static extern string Persian { [MethodImpl] get; }

    public static extern string Gregorian { [MethodImpl] get; }

    public static extern string Hebrew { [MethodImpl] get; }

    public static extern string Hijri { [MethodImpl] get; }

    public static extern string Japanese { [MethodImpl] get; }

    public static extern string Julian { [MethodImpl] get; }

    public static extern string Korean { [MethodImpl] get; }

    public static extern string Taiwan { [MethodImpl] get; }

    public static extern string Thai { [MethodImpl] get; }

    public static extern string UmAlQura { [MethodImpl] get; }
  }
}
