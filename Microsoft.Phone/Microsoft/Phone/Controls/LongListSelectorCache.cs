// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.LongListSelectorCache
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  internal class LongListSelectorCache
  {
    private Queue<ContentPresenter>[] _cache = new Queue<ContentPresenter>[5];

    public ContentPresenter Get(
      LongListSelectorItemKind type,
      Binding templateBinding,
      object context,
      out bool isNew)
    {
      Queue<ContentPresenter> contentPresenterQueue = this._cache[(int) type];
      ContentPresenter contentPresenter;
      if (contentPresenterQueue == null || contentPresenterQueue.Count == 0)
      {
        isNew = true;
        contentPresenter = new ContentPresenter();
        contentPresenter.CacheMode = (CacheMode) new BitmapCache();
        contentPresenter.SetBinding(ContentPresenter.ContentTemplateProperty, templateBinding);
      }
      else
      {
        isNew = false;
        contentPresenter = contentPresenterQueue.Dequeue();
      }
      contentPresenter.Visibility = Visibility.Visible;
      contentPresenter.Content = context;
      return contentPresenter;
    }

    public void Put(LongListSelectorItemKind type, ContentPresenter contentPresenter)
    {
      (this._cache[(int) type] ?? (this._cache[(int) type] = new Queue<ContentPresenter>())).Enqueue(contentPresenter);
      contentPresenter.Visibility = Visibility.Collapsed;
    }
  }
}
