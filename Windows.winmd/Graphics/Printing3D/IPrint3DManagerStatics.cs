// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DManager))]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  [Guid(250727166, 43437, 19464, 169, 23, 29, 31, 134, 62, 171, 203)]
  internal interface IPrint3DManagerStatics
  {
    Print3DManager GetForCurrentView();

    [RemoteAsync]
    IAsyncOperation<bool> ShowPrintUIAsync();
  }
}
