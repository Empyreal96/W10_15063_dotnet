// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.GeographicRegion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Activatable(typeof (IGeographicRegionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGeographicRegionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GeographicRegion : IGeographicRegion
  {
    [MethodImpl]
    public extern GeographicRegion(string geographicRegionCode);

    [MethodImpl]
    public extern GeographicRegion();

    public extern string Code { [MethodImpl] get; }

    public extern string CodeTwoLetter { [MethodImpl] get; }

    public extern string CodeThreeLetter { [MethodImpl] get; }

    public extern string CodeThreeDigit { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string NativeName { [MethodImpl] get; }

    public extern IVectorView<string> CurrenciesInUse { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool IsSupported(string geographicRegionCode);
  }
}
