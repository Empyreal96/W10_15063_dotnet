// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplicationOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(637116407, 37703, 17818, 159, 172, 178, 208, 225, 28, 26, 15)]
  [ExclusiveTo(typeof (Application))]
  internal interface IApplicationOverrides
  {
    void OnActivated(IActivatedEventArgs args);

    void OnLaunched(LaunchActivatedEventArgs args);

    void OnFileActivated(FileActivatedEventArgs args);

    void OnSearchActivated(SearchActivatedEventArgs args);

    void OnShareTargetActivated(ShareTargetActivatedEventArgs args);

    void OnFileOpenPickerActivated(FileOpenPickerActivatedEventArgs args);

    void OnFileSavePickerActivated(FileSavePickerActivatedEventArgs args);

    void OnCachedFileUpdaterActivated(CachedFileUpdaterActivatedEventArgs args);

    void OnWindowCreated(WindowCreatedEventArgs args);
  }
}
