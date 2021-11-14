// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.AlternateNormalizationFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AlternateNormalizationFormat
  {
    NotNormalized = 0,
    Number = 1,
    Currency = 3,
    Date = 4,
    Time = 5,
  }
}
