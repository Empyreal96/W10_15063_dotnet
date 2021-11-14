// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintManagerStatic2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(900307285, 59051, 16697, 154, 189, 184, 106, 114, 155, 53, 152)]
  [ExclusiveTo(typeof (PrintManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPrintManagerStatic2
  {
    bool IsSupported();
  }
}
