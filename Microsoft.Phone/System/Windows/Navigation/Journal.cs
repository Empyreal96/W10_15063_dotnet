// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.Journal
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.TaskModel.Interop;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace System.Windows.Navigation
{
  internal class Journal
  {
    internal const string ExternalUriString = "app://external/";
    private readonly object _syncLock = new object();
    private JournalEntry _currentEntry;
    private JournalEntry _lastRemovedEntry;
    private object _navigationPendingLock = new object();
    private string _knownTypeKey = ApplicationHost.Current.ProductId + "\\knowntypes";
    private string _navStateKey = ApplicationHost.Current.ProductId + "\\NavigationState";
    private Stack<JournalEntry> _backStack = new Stack<JournalEntry>();
    private bool _isNavigationPending;

    internal Journal()
    {
      this.IsBusy = false;
      this.IsNavigationInProgress = false;
      this.HasNavigatedAway = true;
      this.PauseOnBack = false;
      Task rootTask1 = ApplicationHost.Current.RootTask;
      rootTask1.OnSystemKeyPressed = rootTask1.OnSystemKeyPressed + new ITask.SystemKeyPressed(this.SystemKeyPressed);
      Task rootTask2 = ApplicationHost.Current.RootTask;
      rootTask2.OnNavigateTo = rootTask2.OnNavigateTo + new ITask.NavigateTo(this.NavigateTo);
      Task rootTask3 = ApplicationHost.Current.RootTask;
      rootTask3.OnNavigateAway = rootTask3.OnNavigateAway + new ITask.NavigateAway(this.NavigateAway);
      Task rootTask4 = ApplicationHost.Current.RootTask;
      rootTask4.OnRefresh = rootTask4.OnRefresh + new ITask.Refresh(this.Refresh);
      Task rootTask5 = ApplicationHost.Current.RootTask;
      rootTask5.OnPause = rootTask5.OnPause + new ITask.Pause(this.Pause);
      Task rootTask6 = ApplicationHost.Current.RootTask;
      rootTask6.OnResume = rootTask6.OnResume + new ITask.Resume(this.Resume);
      Task rootTask7 = ApplicationHost.Current.RootTask;
      rootTask7.OnRunningInBackground = rootTask7.OnRunningInBackground + new ITask.RunningInBackground(this.RunningInBackground);
      Task rootTask8 = ApplicationHost.Current.RootTask;
      rootTask8.OnOrientationChanged = rootTask8.OnOrientationChanged + new ITask.OrientationChanged(this.OrientationChanged);
      Task rootTask9 = ApplicationHost.Current.RootTask;
      rootTask9.OnLaunching = rootTask9.OnLaunching + new ITask.Launching(this.Launching);
    }

    internal event EventHandler<JournalEventArgs> NavigatingBack;

    internal event EventHandler<JournalEventArgs> Navigated;

    internal event EventHandler<JournalEventArgs> NavigatedExternally;

    internal event EventHandler<CancelEventArgs> BackKeyPress;

    internal event EventHandler<CancelEventArgs> BackKeyPressPreview;

    internal event EventHandler<EventArgs> NavigateToDefaultTaskPage;

    internal bool HasNavigatedAway { get; private set; }

    internal bool CanGoBack => this._backStack.Count > 0;

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This is a reserved method. And it should be a member")]
    internal bool CanGoForward => false;

    internal JournalEntry CurrentEntry => this._currentEntry;

    internal JournalEntry LastRemovedEntry => this._lastRemovedEntry;

    internal Stack<JournalEntry> BackStack => this._backStack;

    internal bool IsBusy { get; set; }

    internal bool CanDeferNavigationRequest { get; private set; }

    internal Uri DeferredNavigation { get; set; }

    internal bool IsNavigationInProgress { get; set; }

    internal bool PauseOnBack { get; set; }

    internal bool KeepLastPageOnNavigateBack => this.PauseOnBack && !this.CanGoBack;

    internal bool TrySetNavigationPending(bool value)
    {
      lock (this._navigationPendingLock)
      {
        if (this._isNavigationPending & value)
          return false;
        this._isNavigationPending = value;
      }
      return true;
    }

    public bool IsForwardResumePending { get; set; }

    internal void AddHistoryPoint(JournalEntry journalEntry)
    {
      Guard.ArgumentNotNull((object) journalEntry, nameof (journalEntry));
      lock (this._syncLock)
      {
        if (this._currentEntry != null)
          this._backStack.Push(this._currentEntry);
        this._currentEntry = journalEntry;
      }
    }

    internal void CompletePendingPage(IPhoneApplicationPage p)
    {
      lock (this._syncLock)
        this._currentEntry.PageInstance = p;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Keep it as member to avoid breaking change.")]
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "This is the correct spelling.", MessageId = "Deeplinks")]
    internal string CheckForDeeplinks()
    {
      string str = (string) null;
      if (!string.IsNullOrEmpty(ApplicationHost.Current.Uri))
      {
        Uri uri = new Uri(ApplicationHost.Current.Uri, UriKind.RelativeOrAbsolute);
        if (uri.IsAbsoluteUri && !string.IsNullOrEmpty(uri.Fragment))
          str = uri.Fragment.Substring(1);
        else if (!string.IsNullOrEmpty(ApplicationHost.Current.TaskPage))
        {
          str = "/" + ApplicationHost.Current.TaskPage;
          if (uri.IsAbsoluteUri && !string.IsNullOrEmpty(uri.Query))
            str += uri.Query;
        }
      }
      return str;
    }

    internal IJournalEntry GetMatchingEntry(IPhoneApplicationPage matchPage)
    {
      IJournalEntry journalEntry1 = (IJournalEntry) null;
      if (this._lastRemovedEntry != null && this._lastRemovedEntry.PageInstance == matchPage)
        journalEntry1 = (IJournalEntry) this._lastRemovedEntry;
      else if (this._backStack.Count > 0)
      {
        foreach (IJournalEntry back in this._backStack)
        {
          if (back is JournalEntry journalEntry5 && journalEntry5.PageInstance == matchPage)
          {
            journalEntry1 = back;
            break;
          }
        }
      }
      return journalEntry1;
    }

    internal void GoBack()
    {
      if (!this.CanGoBack)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.CannotGoBack, (object) "CanGoBack"));
      lock (this._syncLock)
      {
        this._lastRemovedEntry = this._currentEntry;
        this._currentEntry = this.BackStack.Pop();
      }
      this.UpdateObservables(this._currentEntry, NavigationMode.Back);
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Reserve it as member for future.")]
    internal void GoForward() => throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.CannotGoForward, (object) "CanGoForward"));

    internal JournalEntry RemoveBackEntry()
    {
      if (this.BackStack.Count == 0)
        return (JournalEntry) null;
      JournalEntry journalEntry = (JournalEntry) null;
      lock (this._syncLock)
      {
        journalEntry = this.BackStack.Peek();
        this._lastRemovedEntry = journalEntry;
        this.BackStack.Pop();
      }
      return journalEntry;
    }

    internal JournalEntry GetAndClearLastRemovedEntry()
    {
      JournalEntry lastRemovedEntry = this._lastRemovedEntry;
      this._lastRemovedEntry = (JournalEntry) null;
      return lastRemovedEntry;
    }

    internal void UpdateNavigationState(bool isNavigationPending)
    {
      this.IsBusy = isNavigationPending;
      this.TrySetNavigationPending(isNavigationPending);
    }

    protected void OnNavigated(string name, Uri uri, NavigationMode mode, bool IsPaused)
    {
      EventHandler<JournalEventArgs> navigated = this.Navigated;
      if (navigated == null)
        return;
      JournalEventArgs e = new JournalEventArgs(name, uri, mode, IsPaused);
      navigated((object) this, e);
    }

    protected void OnNavigatedExternally(string name, Uri uri, NavigationMode mode)
    {
      EventHandler<JournalEventArgs> navigatedExternally = this.NavigatedExternally;
      if (navigatedExternally == null)
        return;
      navigatedExternally((object) this, new JournalEventArgs(name, uri, mode)
      {
        IsExternal = true
      });
    }

    protected bool OnNavigatingBack(NavigationMode navMode)
    {
      bool flag = false;
      EventHandler<JournalEventArgs> navigatingBack = this.NavigatingBack;
      if (navigatingBack != null && this._backStack.Count > 0)
      {
        JournalEntry journalEntry = this._backStack.Peek();
        bool isPaused = this._currentEntry == null || this._currentEntry.PageInstance == null;
        JournalEventArgs e = new JournalEventArgs(journalEntry.Name, journalEntry.Source, navMode, isPaused);
        e.CancelBack = false;
        navigatingBack((object) this, e);
        flag = e.CancelBack;
      }
      return flag;
    }

    protected void OnNavigateToDefaultTaskPage()
    {
      EventHandler<EventArgs> toDefaultTaskPage = this.NavigateToDefaultTaskPage;
      if (toDefaultTaskPage == null)
        return;
      toDefaultTaskPage((object) this, EventArgs.Empty);
    }

    private void UpdateObservables(JournalEntry currentEntry, NavigationMode mode)
    {
      bool IsPaused = currentEntry.PageInstance == null;
      this.OnNavigated(currentEntry.Name, currentEntry.Source, mode, IsPaused);
    }

    private void Resume(bool isExecutionContextPreserved) => this.CanDeferNavigationRequest = true;

    private void Launching() => this.CanDeferNavigationRequest = true;

    private void NavigateTo(NavigationDirection direction, bool isResumeActivation)
    {
      this.HasNavigatedAway = false;
      this.CanDeferNavigationRequest = false;
      if (ApplicationHost.Current.Rehydrated)
        this.RestoreHistoryPoint();
      if (this._currentEntry == null && this._backStack.Count == 0)
        this.OnNavigateToDefaultTaskPage();
      else if (direction == NavigationDirection.Forward)
      {
        this.DoExternalNavigation(direction, isResumeActivation, false);
        if (!ApplicationHost.Current.Rehydrated || !QuirksMode.ShouldAllowForwardNavigateOnRehydration())
          this.OnNavigateToDefaultTaskPage();
        else
          this.IsForwardResumePending = true;
      }
      else
        this.DoExternalNavigation(direction, isResumeActivation, false);
    }

    internal void OnNavigationComplete()
    {
      if (!this.IsForwardResumePending)
        return;
      this.OnNavigateToDefaultTaskPage();
      this.IsForwardResumePending = false;
    }

    private void DoExternalNavigation(
      NavigationDirection direction,
      bool isResumeActivation,
      bool isRefresh)
    {
      if (this.DeferredNavigation != (Uri) null)
      {
        if (direction == NavigationDirection.Backward)
          this.DoDeferredNavigation(NavigationMode.Back);
        else
          this.DeferredNavigation = (Uri) null;
      }
      else
      {
        NavigationMode navigationMode = isResumeActivation ? (NavigationMode) 4 : NavigationMode.Back;
        if (!ApplicationHost.Current.Rehydrated | isRefresh)
        {
          if (this._currentEntry == null && this._backStack.Count > 0)
          {
            lock (this._syncLock)
              this._currentEntry = this._backStack.Pop();
          }
          if (this._currentEntry == null)
            return;
          this.OnNavigatedExternally("", new Uri(this._currentEntry.Source.ToString(), UriKind.Relative), navigationMode);
        }
        else
        {
          if (!QuirksMode.ShouldAllowForwardNavigateOnRehydration())
            navigationMode = NavigationMode.Back;
          this.NavigateToFirstHistoryPoint(navigationMode);
          if (this._currentEntry == null)
            return;
          this.UpdateObservables(this._currentEntry, navigationMode);
        }
      }
    }

    private void DoDeferredNavigation(NavigationMode mode)
    {
      if (!(this.DeferredNavigation != (Uri) null))
        return;
      this.AddHistoryPoint(new JournalEntry(this.DeferredNavigation.OriginalString, this.DeferredNavigation));
      this.DeferredNavigation = (Uri) null;
      this.OnNavigatedExternally("", new Uri(this._currentEntry.Source.ToString(), UriKind.Relative), mode);
    }

    private void Refresh()
    {
      if (!ApplicationHost.Current.RootTask.IsNavigatedTo || this.IsNavigationInProgress || this._isNavigationPending)
        return;
      this.DoExternalNavigation(NavigationDirection.Forward, true, true);
      this.OnNavigateToDefaultTaskPage();
    }

    private void SystemKeyPressed(NavigationSystemKey systemKeyType, out bool pHandled)
    {
      pHandled = false;
      if (NavigationSystemKey.Back != systemKeyType)
        return;
      bool flag = false;
      CancelEventArgs e = new CancelEventArgs();
      e.Cancel = false;
      EventHandler<CancelEventArgs> backKeyPressPreview = this.BackKeyPressPreview;
      if (backKeyPressPreview != null)
      {
        backKeyPressPreview((object) this, e);
        if (e.Cancel)
        {
          pHandled = true;
          return;
        }
      }
      EventHandler<CancelEventArgs> backKeyPress = this.BackKeyPress;
      if (backKeyPress != null)
        backKeyPress((object) this, e);
      lock (this._syncLock)
      {
        if (this._currentEntry != null)
        {
          if (this._currentEntry.PageInstance != null)
            this._currentEntry.PageInstance.InternalOnBackKeyPress(e);
          if (this.IsBusy || this.IsNavigationInProgress || this._isNavigationPending)
            flag = true;
          else
            flag |= e.Cancel;
        }
      }
      if (!flag)
      {
        flag = this.OnNavigatingBack(NavigationMode.Back);
        if (!flag)
        {
          if (this.CanGoBack)
          {
            this.GoBack();
            flag = true;
          }
          else if (!this.PauseOnBack)
          {
            ApplicationHost.Current.RootTask.Complete(0);
            flag = true;
          }
        }
      }
      pHandled = flag;
    }

    private void OrientationChanged(Orientations orientation)
    {
      lock (this._syncLock)
      {
        if (this._currentEntry == null)
        {
          if (this._backStack.Count <= 0)
            return;
          this._backStack.Peek().PageInstance?.InternalOnUIOrientationChange(orientation);
        }
        else
          this._currentEntry.PageInstance?.InternalOnUIOrientationChange(orientation);
      }
    }

    private void NavigateAway(NavigationDirection direction)
    {
      this.OnNavigatedExternally("", new Uri("app://external/", UriKind.Absolute), NavigationDirection.Backward == direction ? NavigationMode.Back : NavigationMode.New);
      this.HasNavigatedAway = true;
    }

    private void RunningInBackground() => this.SaveHistoryPoint();

    private void Pause(uint unused) => this.SaveHistoryPoint();

    private void SaveHistoryPoint()
    {
      lock (this._syncLock)
      {
        if (this._currentEntry != null)
        {
          this._backStack.Push(this._currentEntry);
          this._currentEntry = (JournalEntry) null;
        }
        IEnumerable<IJournalEntry> journalEntries = this._backStack.Cast<IJournalEntry>();
        IEnumerable<Type> knownTypes = TypesResolver.GetKnownTypes(journalEntries);
        byte[] numArray1 = StreamPersister.Serialize(TypesResolver.GetKnownTypesNames(knownTypes));
        byte[] numArray2 = StreamPersister.Serialize(journalEntries.Reverse<IJournalEntry>(), knownTypes);
        ApplicationHost.Current.RootTask.State[this._knownTypeKey] = numArray1;
        ApplicationHost.Current.RootTask.State[this._navStateKey] = numArray2;
      }
    }

    private void RestoreHistoryPoint()
    {
      if (this._backStack.Count > 0)
        return;
      byte[] blob1 = ApplicationHost.Current.RootTask.State[this._knownTypeKey];
      byte[] blob2 = ApplicationHost.Current.RootTask.State[this._navStateKey];
      if (blob1 == null || blob2 == null)
        return;
      List<string> list = (List<string>) null;
      StreamPersister.Deserialize(blob1, ref list);
      foreach (JournalEntryData journalEntryData in StreamPersister.Deserialize(blob2, BaseTypesResolver.GetKnownTypes(list)))
        this._backStack.Push(new JournalEntry(journalEntryData));
    }

    private void NavigateToFirstHistoryPoint(NavigationMode navMode)
    {
      if (this._backStack.Count <= 0)
        return;
      this.OnNavigatingBack(navMode);
      lock (this._syncLock)
      {
        if (this._backStack.Count <= 0)
          return;
        this._currentEntry = this._backStack.Pop();
      }
    }
  }
}
