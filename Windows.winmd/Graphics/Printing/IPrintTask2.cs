// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTask2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintTask))]
  [Guid(908281975, 15955, 19869, 143, 94, 49, 106, 200, 222, 218, 225)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPrintTask2
  {
    bool IsPreviewEnabled { set; get; }
  }
}
