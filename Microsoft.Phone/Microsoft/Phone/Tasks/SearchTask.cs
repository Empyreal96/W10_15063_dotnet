// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.SearchTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using Windows.Foundation;
using Windows.System;

namespace Microsoft.Phone.Tasks
{
  public sealed class SearchTask
  {
    public string SearchQuery { get; set; }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      string str = string.Empty;
      if (this.SearchQuery != null)
        str = Uri.EscapeDataString(this.SearchQuery);
      WindowsRuntimeSystemExtensions.AsTask<bool>((IAsyncOperation<M0>) Launcher.LaunchUriAsync(new Uri("ms-cortana://searchResults/?mode=1&q=" + str, UriKind.Absolute)));
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }
  }
}
