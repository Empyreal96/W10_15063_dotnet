// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItemPropertiesWithProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(2249978779, 25448, 19950, 180, 14, 116, 104, 74, 92, 231, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItemPropertiesWithProvider : IStorageItemProperties
  {
    StorageProvider Provider { get; }
  }
}
