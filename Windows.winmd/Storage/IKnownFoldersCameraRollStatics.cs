// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersCameraRollStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (KnownFolders))]
  [Guid(1561419366, 10216, 18735, 184, 229, 47, 144, 137, 108, 212, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKnownFoldersCameraRollStatics
  {
    StorageFolder CameraRoll { get; }
  }
}
