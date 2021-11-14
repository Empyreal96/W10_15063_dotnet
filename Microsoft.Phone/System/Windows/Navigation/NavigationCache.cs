// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.NavigationCache
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using System.Collections.Generic;

namespace System.Windows.Navigation
{
  internal sealed class NavigationCache : DependencyObject
  {
    private int _cacheSize;
    private Dictionary<string, IPhoneApplicationPage> _cachePages;
    private List<string> _cachePagesMRU;
    internal static readonly DependencyProperty NavigationCacheModeProperty = DependencyProperty.RegisterAttached("NavigationCacheMode", typeof (NavigationCacheMode), typeof (NavigationCache), new PropertyMetadata((object) NavigationCacheMode.Disabled));

    internal int CachePagesSize => this._cachePages.Count;

    internal int CacheMRUPagesSize => this._cachePagesMRU.Count;

    internal IPhoneApplicationPage this[string uri] => this._cachePages.ContainsKey(uri) ? this._cachePages[uri] : (IPhoneApplicationPage) null;

    internal static NavigationCacheMode GetNavigationCacheMode(
      DependencyObject depObj)
    {
      Guard.ArgumentNotNull((object) depObj, nameof (depObj));
      return (NavigationCacheMode) depObj.GetValue(NavigationCache.NavigationCacheModeProperty);
    }

    internal static void SetNavigationCacheMode(
      DependencyObject depObj,
      NavigationCacheMode navigationCacheMode)
    {
      Guard.ArgumentNotNull((object) depObj, nameof (depObj));
      depObj.SetValue(NavigationCache.NavigationCacheModeProperty, (Enum) navigationCacheMode);
    }

    internal NavigationCache(int initialCacheSize)
    {
      this._cacheSize = initialCacheSize;
      this._cachePages = new Dictionary<string, IPhoneApplicationPage>(this._cacheSize);
      this._cachePagesMRU = new List<string>(this._cacheSize);
    }

    internal void ChangeCacheSize(int newCacheSize)
    {
      while (this._cachePagesMRU.Count > newCacheSize)
      {
        string key = this._cachePagesMRU[this._cachePagesMRU.Count - 1];
        this._cachePagesMRU.RemoveAt(this._cachePagesMRU.Count - 1);
        this._cachePages.Remove(key);
      }
      this._cacheSize = newCacheSize;
    }

    internal bool Contains(string uri) => this._cachePages.ContainsKey(uri);

    internal void AddToCache(string uri, IPhoneApplicationPage page)
    {
      if (this._cachePages.ContainsKey(uri))
      {
        this._cachePagesMRU.Remove(uri);
        this._cachePagesMRU.Insert(0, uri);
        this._cachePages[uri] = page;
      }
      else
      {
        if (this._cacheSize <= 0)
          return;
        if (this._cachePagesMRU.Count == this._cacheSize)
        {
          string key = this._cachePagesMRU[this._cachePagesMRU.Count - 1];
          this._cachePagesMRU.RemoveAt(this._cachePagesMRU.Count - 1);
          this._cachePages.Remove(key);
        }
        this._cachePagesMRU.Insert(0, uri);
        this._cachePages.Add(uri, page);
      }
    }

    internal void RemoveFromCache(string uri)
    {
      this._cachePagesMRU.Remove(uri);
      this._cachePages.Remove(uri);
    }
  }
}
