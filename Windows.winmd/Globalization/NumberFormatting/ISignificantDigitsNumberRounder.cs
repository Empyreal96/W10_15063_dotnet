// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ISignificantDigitsNumberRounder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(4120124362, 26182, 18707, 140, 118, 27, 25, 31, 249, 77, 253)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SignificantDigitsNumberRounder))]
  internal interface ISignificantDigitsNumberRounder
  {
    RoundingAlgorithm RoundingAlgorithm { get; set; }

    uint SignificantDigits { get; set; }
  }
}
