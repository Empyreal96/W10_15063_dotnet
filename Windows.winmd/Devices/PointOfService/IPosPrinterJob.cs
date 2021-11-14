// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterJob
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2593390684, 1557, 17809, 165, 143, 48, 248, 126, 223, 226, 228)]
  public interface IPosPrinterJob
  {
    void Print(string data);

    [Overload("PrintLine")]
    void PrintLine(string data);

    [Overload("PrintNewline")]
    void PrintLine();

    [RemoteAsync]
    IAsyncOperation<bool> ExecuteAsync();
  }
}
