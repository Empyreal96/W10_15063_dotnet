// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomItemDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(1459926583, 23610, 17562, 170, 54, 179, 41, 27, 17, 146, 253)]
  [ExclusiveTo(typeof (PrintCustomItemDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintCustomItemDetails
  {
    string ItemId { get; }

    string ItemDisplayName { set; get; }
  }
}
