// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFilePropertiesWithAvailability
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(2949365403, 22571, 16691, 150, 72, 228, 76, 164, 110, 228, 145)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageFilePropertiesWithAvailability
  {
    bool IsAvailable { get; }
  }
}
