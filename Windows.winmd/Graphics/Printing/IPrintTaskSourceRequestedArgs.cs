// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskSourceRequestedArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(4193281982, 62550, 16880, 156, 152, 92, 231, 62, 133, 20, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTaskSourceRequestedArgs))]
  internal interface IPrintTaskSourceRequestedArgs
  {
    DateTime Deadline { get; }

    void SetSource(IPrintDocumentSource source);

    PrintTaskSourceRequestedDeferral GetDeferral();
  }
}
