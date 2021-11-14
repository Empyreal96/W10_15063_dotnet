// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (KnownFolders))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(424399053, 53102, 19719, 157, 83, 233, 22, 58, 37, 54, 233)]
  internal interface IKnownFoldersStatics2
  {
    StorageFolder Objects3D { get; }

    StorageFolder AppCaptures { get; }

    StorageFolder RecordedCalls { get; }
  }
}
