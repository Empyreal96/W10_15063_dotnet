// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IFileRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [Guid(319045031, 32714, 19499, 158, 202, 104, 144, 249, 240, 1, 133)]
  [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileRemovedEventArgs))]
  internal interface IFileRemovedEventArgs
  {
    string Id { [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
