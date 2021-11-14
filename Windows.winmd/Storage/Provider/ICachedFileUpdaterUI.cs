// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ICachedFileUpdaterUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ExclusiveTo(typeof (CachedFileUpdaterUI))]
  [Guid(2658091494, 47858, 19095, 182, 0, 147, 51, 245, 223, 128, 253)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICachedFileUpdaterUI
  {
    string Title { get; set; }

    CachedFileTarget UpdateTarget { get; }

    event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

    event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;

    UIStatus UIStatus { get; }
  }
}
