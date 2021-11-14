// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MarketplaceLauncher
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Tasks
{
  internal static class MarketplaceLauncher
  {
    public static void Show(MarketplaceContent content, MarketplaceOperation operation)
    {
      if (operation == MarketplaceOperation.Search)
        throw new InvalidOperationException("context");
      MarketplaceLauncher.Show(content, operation, (string) null);
    }

    public static void Show(
      MarketplaceContent content,
      MarketplaceOperation operation,
      string context)
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => MarketplaceLauncher.Show(content, operation, context))))
        return;
      if (operation == MarketplaceOperation.Open)
      {
        if (!string.IsNullOrEmpty(context))
          throw new ArgumentException(nameof (context));
        MarketplaceLauncher.DispatchBrowse(content);
      }
      else if (operation == MarketplaceOperation.Search)
      {
        if (context == null)
          throw new ArgumentNullException(nameof (context));
        if (context.Length == 0)
          throw new ArgumentException(nameof (context));
        MarketplaceLauncher.DispatchSearch(content, context);
      }
      else
      {
        if (operation != MarketplaceOperation.ReviewItem && operation != MarketplaceOperation.ViewDetails)
          throw new ArgumentOutOfRangeException(nameof (operation));
        if (content != MarketplaceContent.Applications)
          throw new ArgumentException(nameof (content));
        string str;
        if (operation == MarketplaceOperation.ReviewItem)
        {
          context = context == null ? new HostInfo().ProductId : throw new ArgumentException(nameof (context));
          str = "reviewapp";
        }
        else
        {
          if (context == null)
            context = new HostInfo().ProductId;
          else
            context = new Guid(context).ToString();
          str = "navigate";
        }
        Dictionary<string, string> arguments = new Dictionary<string, string>();
        ChooserHelper.LaunchSession(MeuxHelper.MakeMarketplaceUri(str + "/?appid=" + context), MeuxHelper.BuildParameterPropertyBag(arguments));
      }
    }

    private static void DispatchBrowse(MarketplaceContent content)
    {
      string relative;
      if (content != MarketplaceContent.Applications)
      {
        if (content != MarketplaceContent.Music)
          throw new ArgumentOutOfRangeException(nameof (content));
        relative = "Store";
      }
      else
        relative = "AppMarketplaceHub";
      Dictionary<string, string> arguments = new Dictionary<string, string>();
      if (relative.Equals("AppMarketplaceHub"))
        ChooserHelper.LaunchSession(MeuxHelper.MakeMarketplaceUri("navigate/?store"), MeuxHelper.BuildParameterPropertyBag(arguments));
      else
        ChooserHelper.LaunchSession(MeuxHelper.MakeXboxMusicUri(relative), MeuxHelper.BuildParameterPropertyBag(arguments));
    }

    private static void DispatchSearch(MarketplaceContent content, string context)
    {
      string str;
      if (content != MarketplaceContent.Applications)
      {
        if (content != MarketplaceContent.Music)
          throw new ArgumentOutOfRangeException(nameof (content));
        str = "music";
      }
      else
        str = "application";
      Dictionary<string, string> arguments = new Dictionary<string, string>();
      if (str.Equals("application"))
        ChooserHelper.LaunchSession(MeuxHelper.MakeMarketplaceUri("search/?keyword=" + context), MeuxHelper.BuildParameterPropertyBag(arguments));
      else
        ChooserHelper.LaunchSession(MeuxHelper.MakeXboxMusicUri("StoreSearch?term=" + context), MeuxHelper.BuildParameterPropertyBag(arguments));
    }
  }
}
