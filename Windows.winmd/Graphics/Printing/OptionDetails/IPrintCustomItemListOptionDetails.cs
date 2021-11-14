// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintCustomItemListOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(2784689544, 22770, 20157, 185, 15, 81, 228, 242, 148, 76, 93)]
  [ExclusiveTo(typeof (PrintCustomItemListOptionDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintCustomItemListOptionDetails : 
    IPrintItemListOptionDetails,
    IPrintOptionDetails,
    IPrintCustomOptionDetails
  {
    void AddItem(string itemId, string displayName);
  }
}
