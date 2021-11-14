// Decompiled with JetBrains decompiler
// Type: System.Windows.Controls.Page
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Windows.Navigation;

namespace System.Windows.Controls
{
  public class Page : UserControl
  {
    internal Page()
    {
    }

    public NavigationContext NavigationContext => JournalEntry.GetNavigationContext((DependencyObject) this);

    public NavigationService NavigationService => NavigationService.GetNavigationService((DependencyObject) this);

    public string Title
    {
      get => JournalEntry.GetName((DependencyObject) this);
      set => JournalEntry.SetName((DependencyObject) this, value);
    }

    public NavigationCacheMode NavigationCacheMode
    {
      get => NavigationCache.GetNavigationCacheMode((DependencyObject) this);
      internal set => NavigationCache.SetNavigationCacheMode((DependencyObject) this, value);
    }

    internal virtual void InternalOnNavigatedTo(NavigationEventArgs e) => this.OnNavigatedTo(e);

    internal void InternalOnNavigatingFrom(NavigatingCancelEventArgs e) => this.OnNavigatingFrom(e);

    internal virtual void InternalOnNavigatedFrom(NavigationEventArgs e) => this.OnNavigatedFrom(e);

    protected virtual void OnFragmentNavigation(FragmentNavigationEventArgs e)
    {
    }

    protected virtual void OnNavigatedTo(NavigationEventArgs e)
    {
    }

    protected virtual void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
    }

    protected virtual void OnNavigatedFrom(NavigationEventArgs e)
    {
    }
  }
}
