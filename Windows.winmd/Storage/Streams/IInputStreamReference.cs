// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IInputStreamReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(1133681944, 24265, 19290, 145, 156, 66, 5, 176, 200, 4, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IInputStreamReference
  {
    [RemoteAsync]
    IAsyncOperation<IInputStream> OpenSequentialReadAsync();
  }
}
