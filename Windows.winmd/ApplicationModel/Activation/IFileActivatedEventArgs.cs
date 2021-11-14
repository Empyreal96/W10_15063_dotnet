// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3140156467, 37809, 17133, 139, 38, 35, 109, 217, 199, 132, 150)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IFileActivatedEventArgs : IActivatedEventArgs
  {
    IVectorView<IStorageItem> Files { get; }

    string Verb { get; }
  }
}
