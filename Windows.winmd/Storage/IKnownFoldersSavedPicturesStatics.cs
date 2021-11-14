// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersSavedPicturesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (KnownFolders))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(89953258, 9533, 18044, 182, 202, 169, 125, 161, 233, 161, 141)]
  internal interface IKnownFoldersSavedPicturesStatics
  {
    StorageFolder SavedPictures { get; }
  }
}
