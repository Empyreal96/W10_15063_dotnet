// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationData2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2657471849, 2979, 20018, 190, 41, 176, 45, 230, 96, 118, 56)]
  [ExclusiveTo(typeof (ApplicationData))]
  internal interface IApplicationData2
  {
    StorageFolder LocalCacheFolder { get; }
  }
}
