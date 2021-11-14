// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.EmailComposeTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Text;
using Windows.Foundation;
using Windows.System;

namespace Microsoft.Phone.Tasks
{
  public sealed class EmailComposeTask
  {
    public string Body { get; set; }

    public string Bcc { get; set; }

    public string Cc { get; set; }

    public int? CodePage { get; set; }

    public string Subject { get; set; }

    public string To { get; set; }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a child task in headless host");
      WindowsRuntimeSystemExtensions.AsTask<bool>((IAsyncOperation<M0>) Launcher.LaunchUriAsync(this.BuildUri()));
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    internal bool AppendToUri(StringBuilder uri, string key, string value, bool hasAddedData)
    {
      if (string.IsNullOrEmpty(value))
        return hasAddedData;
      if (hasAddedData)
        uri.Append('&');
      else
        uri.Append('?');
      uri.Append(key);
      uri.Append('=');
      uri.Append(Uri.EscapeDataString(value));
      return true;
    }

    internal Uri BuildUri()
    {
      StringBuilder uri1 = new StringBuilder("mailto:");
      if (!string.IsNullOrEmpty(this.To))
        uri1.Append(Uri.EscapeDataString(this.To));
      bool hasAddedData = false;
      bool uri2 = this.AppendToUri(uri1, "cc", this.Cc, hasAddedData);
      bool uri3 = this.AppendToUri(uri1, "bcc", this.Bcc, uri2);
      bool uri4 = this.AppendToUri(uri1, "subject", this.Subject, uri3);
      bool uri5 = this.AppendToUri(uri1, "body", this.Body, uri4);
      if (this.CodePage.HasValue)
        this.AppendToUri(uri1, "ms-codepage", this.CodePage.Value.ToString(), uri5);
      return new Uri(uri1.ToString(), UriKind.Absolute);
    }
  }
}
