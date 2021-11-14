// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IIncrementNumberRounder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(1889947640, 26283, 16725, 157, 161, 115, 158, 70, 118, 69, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (IncrementNumberRounder))]
  internal interface IIncrementNumberRounder
  {
    RoundingAlgorithm RoundingAlgorithm { get; set; }

    double Increment { get; set; }
  }
}
