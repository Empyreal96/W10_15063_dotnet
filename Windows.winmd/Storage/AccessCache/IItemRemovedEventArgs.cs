// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IItemRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ExclusiveTo(typeof (ItemRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1499954780, 21950, 19558, 186, 102, 94, 174, 167, 157, 38, 49)]
  internal interface IItemRemovedEventArgs
  {
    AccessListEntry RemovedEntry { get; }
  }
}
