// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintNumberOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(1291959215, 25692, 19945, 150, 95, 111, 198, 187, 196, 124, 171)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintNumberOptionDetails : IPrintOptionDetails
  {
    uint MinValue { get; }

    uint MaxValue { get; }
  }
}
