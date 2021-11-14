// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ISearchActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(2360568145, 22728, 17379, 148, 188, 65, 211, 63, 139, 99, 14)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISearchActivatedEventArgs : IActivatedEventArgs
  {
    string QueryText { get; }

    string Language { get; }
  }
}
