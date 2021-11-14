// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintPageInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3712739785, 42657, 19162, 147, 14, 218, 135, 42, 79, 35, 211)]
  [ExclusiveTo(typeof (PrintPageInfo))]
  [WebHostHidden]
  internal interface IPrintPageInfo
  {
    PrintMediaSize MediaSize { set; get; }

    Size PageSize { set; get; }

    uint DpiX { set; get; }

    uint DpiY { set; get; }

    PrintOrientation Orientation { set; get; }
  }
}
