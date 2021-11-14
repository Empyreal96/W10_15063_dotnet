// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskSourceRequestedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintTaskSourceRequestedDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1242915025, 27026, 19869, 133, 85, 76, 164, 86, 63, 177, 102)]
  internal interface IPrintTaskSourceRequestedDeferral
  {
    void Complete();
  }
}
