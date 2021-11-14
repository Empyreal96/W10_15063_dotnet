// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionDetailsStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(324903315, 2401, 19310, 135, 102, 241, 59, 127, 188, 205, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskOptionDetails))]
  internal interface IPrintTaskOptionDetailsStatic
  {
    PrintTaskOptionDetails GetFromPrintTaskOptions(
      PrintTaskOptions printTaskOptions);
  }
}
