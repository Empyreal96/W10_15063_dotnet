// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomTextOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(718369272, 51389, 18693, 145, 146, 13, 117, 19, 110, 139, 49)]
  [ExclusiveTo(typeof (PrintCustomTextOptionDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintCustomTextOptionDetails : IPrintCustomOptionDetails, IPrintOptionDetails
  {
    uint MaxCharacters { set; get; }
  }
}
