// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskRequestedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskRequestedDeferral))]
  [Guid(3488592880, 52798, 17095, 148, 150, 100, 128, 12, 98, 44, 68)]
  internal interface IPrintTaskRequestedDeferral
  {
    void Complete();
  }
}
