// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.SmsComposeTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using Windows.ApplicationModel.Chat;

namespace Microsoft.Phone.Tasks
{
  public sealed class SmsComposeTask
  {
    public string Body { get; set; }

    public string To { get; set; }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a child task in headless host");
      ChatMessage chatMessage = new ChatMessage();
      chatMessage.put_Body(this.Body ?? string.Empty);
      if (!string.IsNullOrEmpty(this.To))
        chatMessage.Recipients.Add(this.To);
      WindowsRuntimeSystemExtensions.AsTask(ChatMessageManager.ShowComposeSmsMessageAsync(chatMessage));
    }
  }
}
