// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(3811302940, 10415, 19344, 149, 218, 163, 172, 243, 32, 185, 41)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintCustomOptionDetails : IPrintOptionDetails
  {
    string DisplayName { set; get; }
  }
}
