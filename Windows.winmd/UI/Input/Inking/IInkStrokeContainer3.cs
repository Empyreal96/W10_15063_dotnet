// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeContainer3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkStrokeContainer))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1023917733, 47850, 19586, 167, 25, 123, 131, 218, 16, 103, 210)]
  internal interface IInkStrokeContainer3
  {
    [RemoteAsync]
    [Overload("SaveWithFormatAsync")]
    IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream,
      InkPersistenceFormat inkPersistenceFormat);

    InkStroke GetStrokeById(uint id);
  }
}
