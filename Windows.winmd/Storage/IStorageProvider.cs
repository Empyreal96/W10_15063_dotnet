// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageProvider))]
  [Guid(3875925716, 54392, 18390, 186, 70, 26, 142, 190, 17, 74, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageProvider
  {
    string Id { get; }

    string DisplayName { get; }
  }
}
