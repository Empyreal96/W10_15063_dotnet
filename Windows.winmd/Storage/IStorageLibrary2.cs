// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibrary2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(1527571272, 64691, 16433, 175, 176, 166, 141, 123, 212, 69, 52)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (StorageLibrary))]
  internal interface IStorageLibrary2
  {
    StorageLibraryChangeTracker ChangeTracker { get; }
  }
}
