// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChangeTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageLibraryChangeTracker))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2652205846, 24691, 17654, 150, 129, 116, 146, 209, 40, 108, 144)]
  internal interface IStorageLibraryChangeTracker
  {
    StorageLibraryChangeReader GetChangeReader();

    void Enable();

    void Reset();
  }
}
