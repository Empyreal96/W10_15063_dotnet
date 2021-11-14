// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class FileRemovedEventArgs : IFileRemovedEventArgs
  {
    public extern string Id { [Deprecated("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
