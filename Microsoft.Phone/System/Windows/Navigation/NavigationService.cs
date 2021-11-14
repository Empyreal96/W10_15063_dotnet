// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.NavigationService
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using Microsoft.Phone.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace System.Windows.Navigation
{
  public sealed class NavigationService
  {
    private IPhoneApplicationFrame _host;
    private Uri _currentSource;
    private Uri _currentSourceAfterMapping;
    private Uri _source;
    private Uri _pendingSource;
    private Journal _journal;
    private ContentLoaderBase _contentLoader;
    private object _navigationPendingLock = new object();
    private NavigationService.NavigationOperation _currentNavigation;
    private Dictionary<string, IPhoneApplicationPage> _cacheRequiredPages = new Dictionary<string, IPhoneApplicationPage>();
    private bool _quirkShouldNotAllowBackgroundNavigation;
    private bool _quirkShouldCallOnNavigatingFromPageForExternalNav;
    private bool _quirkShouldForceTextBindings;
    private bool _initialNavigate = true;
    private bool _refreshOnIdenticalNav;
    internal static readonly DependencyProperty NavigationServiceProperty = DependencyProperty.RegisterAttached(nameof (NavigationService), typeof (NavigationService), typeof (NavigationService), new PropertyMetadata((PropertyChangedCallback) null));
    private bool _isNavigationInProgress;
    private bool _isNavigationPending;

    internal NavigationService(IPhoneApplicationFrame nav)
    {
      PerfUtil.BeginLogMarker(MarkerEvents.TH_INIT_NAVIGATIONSERVICE, "NavigationService started");
      Guard.ArgumentNotNull((object) nav, nameof (nav));
      this._host = nav;
      NavigationService.HostFrame = nav;
      this._quirkShouldNotAllowBackgroundNavigation = QuirksMode.ShouldNotAllowBackgroundNavigation();
      this._quirkShouldCallOnNavigatingFromPageForExternalNav = QuirksMode.ShouldCallOnNavigatingFromPageForExternalNavigations();
      this._quirkShouldForceTextBindings = QuirksMode.ShouldForceTextBindings();
      ChooserListener.Initialize();
    }

    ~NavigationService() => PerfUtil.EndLogMarker(MarkerEvents.TH_INIT_NAVIGATIONSERVICE, "NavigationService stopped");

    public event NavigationFailedEventHandler NavigationFailed;

    public event NavigatingCancelEventHandler Navigating;

    public event NavigatedEventHandler Navigated;

    public event NavigationStoppedEventHandler NavigationStopped;

    public event FragmentNavigationEventHandler FragmentNavigation;

    public event EventHandler<JournalEntryRemovedEventArgs> JournalEntryRemoved;

    internal static NavigationService GetNavigationService(
      DependencyObject dependencyObject)
    {
      Guard.ArgumentNotNull((object) dependencyObject, nameof (dependencyObject));
      return dependencyObject.GetValue(NavigationService.NavigationServiceProperty) as NavigationService;
    }

    internal Journal Journal => this._journal;

    internal ContentLoaderBase ContentLoader => this._contentLoader;

    internal IFrame Host => (IFrame) this._host;

    internal static IPhoneApplicationFrame HostFrame { get; private set; }

    internal NavigationCache Cache { get; private set; }

    public Uri Source
    {
      get => this._source;
      set
      {
        this._source = value;
        this.Navigate(value);
      }
    }

    public Uri CurrentSource
    {
      get => this._currentSource;
      internal set => this._currentSource = value;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This is a reserved method. And it should be a member")]
    public bool CanGoForward => false;

    public bool CanGoBack => this._journal.CanGoBack && !this.IsNavigationInProgress;

    public bool PauseOnBack
    {
      get => this._journal.PauseOnBack;
      set => this._journal.PauseOnBack = value;
    }

    public IEnumerable<JournalEntry> BackStack => (IEnumerable<JournalEntry>) this._journal.BackStack;

    internal bool IsBackground { get; private set; }

    internal void InitializeJournal()
    {
      Journal journal = this._journal;
      frame2 = (IFrame) null;
      DependencyObject parent = VisualTreeHelper.GetParent(this.Host as DependencyObject);
      while (true)
      {
        switch (parent)
        {
          case null:
          case IFrame frame2:
            goto label_3;
          default:
            parent = VisualTreeHelper.GetParent(parent);
            continue;
        }
      }
label_3:
      if (this.Host.JournalOwnership == JournalOwnership.OwnsJournal || this.Host.IsInDesignModeX())
      {
        this._journal = new Journal();
      }
      else
      {
        if (this.Host.JournalOwnership == JournalOwnership.UsesParentJournal && frame2 != null)
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.NavigationService_JournalOwnership_UsesParentJournal_OnlyTopLevel, (object) "JournalOwnership", (object) "UsesParentJournal", (object) "Frame"));
        this._journal = this.Host.JournalOwnership != JournalOwnership.Automatic || frame2 == null ? new Journal() : new Journal();
      }
      if (this._journal == journal)
        return;
      if (journal != null)
      {
        journal.Navigated -= new EventHandler<JournalEventArgs>(this.Journal_Navigated);
        journal.NavigatedExternally -= new EventHandler<JournalEventArgs>(this.Journal_NavigatedExternally);
        journal.NavigatingBack -= new EventHandler<JournalEventArgs>(this.Journal_NavigatingBack);
        journal.BackKeyPress -= new EventHandler<CancelEventArgs>(this.Host.InternalOnBackKeyPress);
        journal.BackKeyPressPreview -= new EventHandler<CancelEventArgs>(this.Host.InternalOnBackKeyPressPreview);
        journal.NavigateToDefaultTaskPage -= new EventHandler<EventArgs>(this.Host.InternalNavigateToDefaultTaskPage);
      }
      this._journal.Navigated += new EventHandler<JournalEventArgs>(this.Journal_Navigated);
      this._journal.NavigatedExternally += new EventHandler<JournalEventArgs>(this.Journal_NavigatedExternally);
      this._journal.NavigatingBack += new EventHandler<JournalEventArgs>(this.Journal_NavigatingBack);
      this._journal.BackKeyPress += new EventHandler<CancelEventArgs>(this.Host.InternalOnBackKeyPress);
      this._journal.BackKeyPressPreview += new EventHandler<CancelEventArgs>(this.Host.InternalOnBackKeyPressPreview);
      this._journal.NavigateToDefaultTaskPage += new EventHandler<EventArgs>(this.Host.InternalNavigateToDefaultTaskPage);
    }

    internal void InitializeContentLoader() => this._contentLoader = (ContentLoaderBase) new PageResourceContentLoader();

    internal void InitializeNavigationCache() => this.Cache = new NavigationCache(this.Host.CacheSize);

    public bool Navigate(Uri source)
    {
      NavigationMode mode = NavigationMode.New;
      PerfUtil.BeginLogMarker(MarkerEvents.TH_PAGE_NAVIGATION, "Page navigation: " + (source == (Uri) null ? "" : source.ToString()));
      try
      {
        Uri uri = !(source == (Uri) null) ? this.GetMappedUri(source) : throw new ArgumentNullException(nameof (source), Resource.NavigationService_NavigationToANullUriIsNotSupported);
        Uri mergedUri = this.GetMergedUri(source);
        if (UriParsingHelper.InternalUriToExternalValue(mergedUri) == UriParsingHelper.InternalUriToExternalValue(this._currentSource) || UriParsingHelper.InternalUriToExternalValue(mergedUri) == UriParsingHelper.InternalUriToExternalValue(this._pendingSource))
        {
          if (this.ShouldRefreshOnIdenticalNav())
            this.RaiseNavigated(this.Host.Content, source, NavigationMode.Refresh, true, (IPhoneApplicationPage) null, this.Host.Content as IPhoneApplicationPage);
          return true;
        }
        this._refreshOnIdenticalNav = false;
        if (this._journal.CanDeferNavigationRequest)
        {
          this._journal.DeferredNavigation = source;
          return true;
        }
        if (!this.TrySetNavigationPending(true))
        {
          if (this._quirkShouldNotAllowBackgroundNavigation && this.IsBackground)
            throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.NavigateWhileInBackground));
          return false;
        }
        this._pendingSource = mergedUri;
        if (!this.Host.Dispatcher.CheckAccess())
        {
          this.Host.Dispatcher.BeginInvoke((Action) (() => this.Navigate(source)));
          return true;
        }
        bool isFragmentNavigationOnly = UriParsingHelper.InternalUriIsFragment(uri) || UriParsingHelper.InternalUriGetAllButFragment(mergedUri) == UriParsingHelper.InternalUriGetAllButFragment(this._currentSource);
        if (isFragmentNavigationOnly)
          throw new InvalidOperationException("No Fragment support right now");
        if (!UriParsingHelper.InternalUriIsNavigable(uri))
          throw new ArgumentException(Resource.NavigationService_UriNotNavigable, "uri");
        if (isFragmentNavigationOnly && this.Host.Content == null)
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.NavigationService_FragmentNavigationRequiresContent, (object) "Frame"));
        if (mode == NavigationMode.New && this.RaiseNavigating(mergedUri, mode, isFragmentNavigationOnly, true, this.Host.Content != null, this.Host.Content as IPhoneApplicationPage))
        {
          this.RaiseNavigationStopped((object) null, mergedUri, mode);
          return true;
        }
        this.Journal.AddHistoryPoint(new JournalEntry(source.OriginalString, source));
        return this.NavigateCore_StartNavigation(source, NavigationMode.New, false);
      }
      catch (Exception ex)
      {
        if (!this.RaiseNavigationFailed(source, ex))
          return true;
        throw;
      }
    }

    private bool ShouldRefreshOnIdenticalNav() => this._journal.IsForwardResumePending || this._refreshOnIdenticalNav;

    private void Journal_Navigated(object sender, JournalEventArgs args)
    {
      if (this.IsBackground)
        this.IsBackground = false;
      this.NavigateCore_StartNavigation(args.Uri, args.NavigationMode, args.IsPaused);
    }

    private void Journal_NavigatingBack(object sender, JournalEventArgs args)
    {
      if (!args.IsPaused)
        args.CancelBack = this.RaiseNavigating(args.Uri, args.NavigationMode, false, true, true, this.Host.Content as IPhoneApplicationPage);
      else
        args.CancelBack = this.RaiseNavigating(args.Uri, args.NavigationMode, false, false, false, (IPhoneApplicationPage) null);
    }

    private void Journal_NavigatedExternally(object sender, JournalEventArgs args)
    {
      Application.Current.IsNavigatingExternally = true;
      if (args.NavigationMode == NavigationMode.New)
      {
        this.RaiseNavigating(args.Uri, args.NavigationMode, false, false, false, this.Host.Content as IPhoneApplicationPage);
        if (this._quirkShouldForceTextBindings)
          this.ForceTextBindings();
        this.RaiseNavigated((object) null, args.Uri, args.NavigationMode, false, this.Host.Content as IPhoneApplicationPage, (IPhoneApplicationPage) null);
        this.IsBackground = true;
      }
      else if (args.NavigationMode == NavigationMode.Back || args.NavigationMode == NavigationMode.Forward)
      {
        if (args.Uri.Equals((object) "app://external/"))
        {
          this.RaiseNavigating(args.Uri, args.NavigationMode, false, false, false, this.Host.Content as IPhoneApplicationPage);
          if (this._quirkShouldForceTextBindings)
            this.ForceTextBindings();
          this.RaiseNavigated((object) null, args.Uri, args.NavigationMode, false, this.Host.Content as IPhoneApplicationPage, (IPhoneApplicationPage) null);
          if (this._journal.CurrentEntry != null && !this._journal.KeepLastPageOnNavigateBack)
            this.RaiseJournalEntryRemoved(this._journal.CurrentEntry);
          this.IsBackground = true;
        }
        else
        {
          this.RaiseNavigating(args.Uri, args.NavigationMode, false, false, false, (IPhoneApplicationPage) null);
          this.IsBackground = false;
          if (this._journal.CurrentEntry.PageInstance != null)
            this.RaiseNavigated(this.Host.Content, args.Uri, args.NavigationMode, false, (IPhoneApplicationPage) null, this.Host.Content as IPhoneApplicationPage);
          else
            this.NavigateCore_StartNavigation(args.Uri, args.NavigationMode, true);
        }
      }
      else if (args.NavigationMode == (NavigationMode) 4)
      {
        this.IsBackground = false;
        this.RaiseNavigating(args.Uri, args.NavigationMode, false, false, false, (IPhoneApplicationPage) null);
        this.RaiseNavigated(this.Host.Content, args.Uri, args.NavigationMode, false, (IPhoneApplicationPage) null, this.Host.Content as IPhoneApplicationPage);
        this._refreshOnIdenticalNav = true;
      }
      Application.Current.IsNavigatingExternally = false;
    }

    private bool NavigateCore_StartNavigation(Uri uri, NavigationMode mode, bool isPagePaused)
    {
      try
      {
        this._currentNavigation = new NavigationService.NavigationOperation(this.GetMergedUriAfterMapping(this.GetMappedUri(uri)), this.GetMergedUri(uri), uri, mode);
        this.IsNavigationInProgress = true;
        if (!isPagePaused && mode == NavigationMode.Back)
        {
          IPhoneApplicationPage reusedPage = this._journal.CurrentEntry.PageInstance;
          this.Host.Dispatcher.BeginInvoke((Action) (() => this.CompleteNavigation(reusedPage as DependencyObject, mode)));
        }
        else
        {
          if (!isPagePaused && mode != NavigationMode.New)
            throw new InvalidOperationException("Invalid NavigationMode, only New and Back are supported");
          this._contentLoader.BeginLoad(this._currentNavigation.Uri, new AsyncCallback(this.ContentLoader_BeginLoad_Callback), (object) this._currentNavigation);
        }
      }
      catch (Exception ex)
      {
        if (this.RaiseNavigationFailed(uri, ex))
          throw;
      }
      return true;
    }

    [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "The exception should always be caught and used to raise a failure event instead.")]
    private void ContentLoader_BeginLoad_Callback(IAsyncResult result)
    {
      Uri uri = (Uri) null;
      try
      {
        NavigationService.NavigationOperation asyncState = result.AsyncState as NavigationService.NavigationOperation;
        NavigationService.NavigationOperation currentNavigation = this._currentNavigation;
        if (currentNavigation == null || currentNavigation.Uri != asyncState.Uri)
          return;
        if (this._journal.CurrentEntry == null || this._journal.HasNavigatedAway)
        {
          this.RaiseNavigationStopped((object) null, asyncState.Uri, asyncState.Mode);
        }
        else
        {
          uri = currentNavigation.UriBeforeMapping;
          DependencyObject content = this._contentLoader.EndLoad(result) as DependencyObject;
          if (!(content is UserControl))
            throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.NavigationService_ContentIsNotAUserControl, content == null ? (object) "null" : (object) content.GetType().ToString(), (object) "System.Windows.Controls.UserControl"));
          if (content is IPhoneApplicationPage p4)
          {
            this._journal.CompletePendingPage(p4);
            p4.BeginLayoutChanged += new EventHandler<OrientationChangedEventArgs>(this.Host.InternalOnBeginLayoutChanged);
            p4.BeginOrientationChanged += new EventHandler<OrientationChangedEventArgs>(this.Host.InternalOnBeginOrientationChanged);
            p4.InternalVisibleRegionChanged += new EventHandler<VisibleRegionChangeEventArgs>(this.Host.InternalOnVisibleRegionChange);
          }
          JournalEntry.SetNavigationContext(content, new NavigationContext(UriParsingHelper.InternalUriParseQueryStringToDictionary(asyncState.Uri, true)));
          content.SetValue(NavigationService.NavigationServiceProperty, (object) this);
          this.CompleteNavigation(content, asyncState.Mode);
        }
      }
      catch (Exception ex)
      {
        if (!this.RaiseNavigationFailed(uri, ex))
          return;
        throw;
      }
    }

    private void CompleteNavigation(DependencyObject content, NavigationMode mode)
    {
      Uri uri = (Uri) null;
      IPhoneApplicationPage existingContentPage = mode == (NavigationMode) 4 ? (IPhoneApplicationPage) null : this._host.Content as IPhoneApplicationPage;
      IPhoneApplicationPage phoneApplicationPage = content as IPhoneApplicationPage;
      JournalEntry.GetName(content ?? this._host.Content as DependencyObject);
      NavigationService.NavigationOperation currentNavigation = this._currentNavigation;
      this._currentNavigation = (NavigationService.NavigationOperation) null;
      this.IsNavigationInProgress = false;
      this.IsNavigationPending = false;
      if (currentNavigation != null)
      {
        uri = currentNavigation.UriBeforeMapping;
        this.CurrentSource = currentNavigation.UriForJournal;
        this._source = currentNavigation.UriBeforeMapping;
        this._currentSourceAfterMapping = currentNavigation.Uri;
        this.Host.UpdateSourceFromNavigationService(currentNavigation.UriForJournal);
        this.Host.CurrentSource = this.CurrentSource;
        this.Host.CanGoBack = this.CanGoBack;
        this.Host.CanGoForward = this.CanGoForward;
      }
      if (this._quirkShouldForceTextBindings)
        this.ForceTextBindings();
      existingContentPage?.Focus();
      if (content == null)
      {
        if (currentNavigation != null)
          this.RaiseFragmentNavigation(UriParsingHelper.InternalUriGetFragment(currentNavigation.Uri));
        this.RaiseNavigated((object) content, uri, mode, true, existingContentPage, phoneApplicationPage);
      }
      else
      {
        this.Host.Content = (object) content;
        this.Host.InternalRaiseFocusChangedAutomationEvent();
        this.RaiseNavigated((object) content, uri, mode, existingContentPage != null, existingContentPage, phoneApplicationPage);
        this.Host.InternalUpdateOrientationAndMarginForPage(phoneApplicationPage);
        if (NavigationMode.Back == mode)
        {
          JournalEntry lastRemovedEntry = this._journal.GetAndClearLastRemovedEntry();
          if (lastRemovedEntry != null)
            this.RaiseJournalEntryRemoved(lastRemovedEntry);
        }
        string fragment = (string) null;
        if (currentNavigation != null)
          fragment = UriParsingHelper.InternalUriGetFragment(currentNavigation.Uri);
        if (!string.IsNullOrEmpty(fragment))
          this.RaiseFragmentNavigation(fragment);
      }
      if (this._initialNavigate)
      {
        DispatchHelper.BeginFastInvoke((Action) (() => { }), this.Host.Dispatcher);
        this._initialNavigate = false;
      }
      PerfUtil.EndLogMarker(MarkerEvents.TH_PAGE_NAVIGATION, "Page navigation: Success");
      this._journal.OnNavigationComplete();
    }

    private void UpdateNavigationCacheModeAlwaysPages()
    {
      if (!(this.Host.Content is IPhoneApplicationPage content))
        return;
      string allButFragment = UriParsingHelper.InternalUriGetAllButFragment(this.CurrentSource);
      if (content.NavigationCacheMode == NavigationCacheMode.Required)
        this._cacheRequiredPages[allButFragment] = content;
      else
        this._cacheRequiredPages.Remove(allButFragment);
      if (content.NavigationCacheMode == NavigationCacheMode.Enabled)
        this.Cache.AddToCache(allButFragment, content);
      else
        this.Cache.RemoveFromCache(allButFragment);
    }

    private Uri GetMappedUri(Uri uri)
    {
      Uri uri1 = uri;
      if (!UriParsingHelper.InternalUriIsFragment(uri))
      {
        UriMapperBase uriMapper = this.Host.UriMapper;
        if (uriMapper != null)
        {
          Uri uri2 = uriMapper.MapUri(uri);
          uri1 = !(uri2 != (Uri) null) || string.IsNullOrEmpty(uri2.OriginalString) ? uri : uri2;
        }
      }
      return uri1;
    }

    private Uri GetMergedUriAfterMapping(Uri mappedUri)
    {
      Uri uri = UriParsingHelper.InternalUriMerge(this._currentSourceAfterMapping, mappedUri);
      return (object) uri != null ? uri : mappedUri;
    }

    private Uri GetMergedUri(Uri uri)
    {
      Uri uri1 = UriParsingHelper.InternalUriMerge(this._currentSource, uri);
      return (object) uri1 != null ? uri1 : uri;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This is a reserved method. And it should be a member")]
    public void GoForward() => throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.CannotGoForward, (object) "CanGoForward"));

    public void GoBack()
    {
      if (!this.TrySetNavigationPending(true))
        return;
      if (!this.Host.Dispatcher.CheckAccess())
      {
        this.Host.Dispatcher.BeginInvoke((Action) (() => this.GoBack()));
      }
      else
      {
        PerfUtil.BeginLogMarker(MarkerEvents.TH_GOBACK_NAVIGATIONSERVICE, "NavigationService::GoBack");
        this.GoForwardBackCore(NavigationMode.Back, (this.CanGoBack ? 1 : 0) != 0, this.Journal.BackStack, string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.CannotGoBack, (object) "CanGoBack"));
        PerfUtil.EndLogMarker(MarkerEvents.TH_GOBACK_NAVIGATIONSERVICE, "NavigationService::GoBack");
      }
    }

    public void StopLoading()
    {
    }

    public JournalEntry RemoveBackEntry()
    {
      if (!this.Host.Dispatcher.CheckAccess())
        throw new UnauthorizedAccessException("RemoveBackEntry() can be called on UI thread only.");
      JournalEntry entry = this._journal.RemoveBackEntry();
      if (entry != null)
        this.RaiseJournalEntryRemoved(entry);
      return entry;
    }

    private void GoForwardBackCore(
      NavigationMode mode,
      bool canDoIt,
      Stack<JournalEntry> entries,
      string onFailureText)
    {
      if (canDoIt)
      {
        JournalEntry journalEntry = entries.Peek();
        bool isFragmentNavigationOnly = UriParsingHelper.InternalUriIsFragment(journalEntry.Source) || UriParsingHelper.InternalUriGetAllButFragment(journalEntry.Source) == UriParsingHelper.InternalUriGetAllButFragment(this._currentSourceAfterMapping);
        if (!this.RaiseNavigating(journalEntry.Source, mode, isFragmentNavigationOnly, true, true, this.Host.Content as IPhoneApplicationPage))
        {
          if (mode == NavigationMode.Back)
            this.Journal.GoBack();
          else
            this.Journal.GoForward();
        }
        else
          this.RaiseNavigationStopped((object) null, journalEntry.Source, mode);
      }
      else
      {
        Exception exception = (Exception) new InvalidOperationException(onFailureText);
        if (this.RaiseNavigationFailed((Uri) null, exception))
          throw exception;
      }
    }

    private void OnInvokeReturning(object sender, InvokeReturningEventArgs args)
    {
      if (this._journal == null)
        return;
      this._journal.UpdateNavigationState(false);
    }

    internal bool IsNavigationInProgress
    {
      get
      {
        if (this._isNavigationInProgress)
          return true;
        return this._journal != null && this._journal.IsBusy;
      }
      set
      {
        this._isNavigationInProgress = value;
        if (this._journal == null)
          return;
        this._journal.IsNavigationInProgress = value;
      }
    }

    private bool IsNavigationPending
    {
      get => this._isNavigationPending || this.IsNavigationInProgress;
      set
      {
        if (!this.TrySetNavigationPending(value))
          throw new InvalidOperationException("Navigation is already pending");
      }
    }

    private bool TrySetNavigationPending(bool value)
    {
      lock (this._navigationPendingLock)
      {
        if (((!this._quirkShouldNotAllowBackgroundNavigation ? 0 : (this.IsBackground ? 1 : 0)) & (value ? 1 : 0)) != 0 || this.IsNavigationPending & value || this._journal != null && !this._journal.TrySetNavigationPending(value))
          return false;
        this._isNavigationPending = value;
        if (!value)
          this._pendingSource = (Uri) null;
      }
      return true;
    }

    private void RaiseNavigated(
      object content,
      Uri uri,
      NavigationMode mode,
      bool isNavigationInitiator,
      IPhoneApplicationPage existingContentPage,
      IPhoneApplicationPage newContentPage)
    {
      NavigatedEventHandler navigated = this.Navigated;
      this.IsNavigationInProgress = false;
      this.IsNavigationPending = false;
      if (navigated != null)
      {
        NavigationEventArgs e = new NavigationEventArgs(content, uri, mode, isNavigationInitiator);
        PerfUtil.BeginLogMarker(MarkerEvents.TH_NAVIGATED_NAVIGATIONSERVICE, uri == (Uri) null ? "" : uri.ToString());
        navigated((object) this, e);
        PerfUtil.EndLogMarker(MarkerEvents.TH_NAVIGATED_NAVIGATIONSERVICE, uri == (Uri) null ? "" : uri.ToString());
      }
      if (existingContentPage != null)
      {
        PerfUtil.InfoLogMarker(MarkerEvents.TH_ONNAVIGATEDFROM_PAGE, string.Format("{0},{1},{2}", (object) existingContentPage, (object) mode, (object) newContentPage));
        existingContentPage.InternalOnNavigatedFromX(new NavigationEventArgs(content, uri, mode, isNavigationInitiator));
      }
      if (newContentPage == null)
        return;
      PerfUtil.InfoLogMarker(MarkerEvents.TH_ONNAVIGATEDTO_PAGE, string.Format("{0},{1},{2},{3}", (object) newContentPage, (object) mode, (object) uri, (object) existingContentPage));
      newContentPage.InternalOnNavigatedToX(new NavigationEventArgs(content, uri, mode, isNavigationInitiator));
    }

    private bool RaiseNavigating(
      Uri uri,
      NavigationMode mode,
      bool isFragmentNavigationOnly,
      bool isCancelable,
      bool isNavigationInitiator,
      IPhoneApplicationPage existingContentPage)
    {
      NavigatingCancelEventHandler navigating = this.Navigating;
      bool flag = false;
      if (navigating != null)
      {
        NavigatingCancelEventArgs e = new NavigatingCancelEventArgs(uri, mode, isCancelable, isNavigationInitiator);
        PerfUtil.BeginLogMarker(MarkerEvents.TH_NAVIGATING_NAVIGATIONSERVICE, uri == (Uri) null ? "" : uri.ToString());
        navigating((object) this, e);
        flag = e.Cancel;
        PerfUtil.EndLogMarker(MarkerEvents.TH_NAVIGATING_NAVIGATIONSERVICE, uri == (Uri) null ? "" : uri.ToString() + " Canceled: " + flag.ToString());
      }
      if (this._quirkShouldCallOnNavigatingFromPageForExternalNav && !isNavigationInitiator && this.Host.Content != null)
        flag = false;
      if (!flag && !isFragmentNavigationOnly && existingContentPage != null)
      {
        NavigatingCancelEventArgs e = new NavigatingCancelEventArgs(uri, mode, isCancelable, isNavigationInitiator);
        existingContentPage.InternalOnNavigatingFromX(e);
        flag |= e.Cancel;
      }
      return flag;
    }

    private bool RaiseNavigationFailed(Uri uri, Exception exception)
    {
      PerfUtil.EndLogMarker(MarkerEvents.TH_PAGE_NAVIGATION, "Page navigation: Failed, " + (uri == (Uri) null ? "" : uri.ToString()));
      NavigationFailedEventHandler navigationFailed = this.NavigationFailed;
      NavigationFailedEventArgs e = new NavigationFailedEventArgs(uri, exception);
      this.IsNavigationInProgress = false;
      this.IsNavigationPending = false;
      if (navigationFailed != null)
        navigationFailed((object) this, e);
      return !e.Handled;
    }

    private void RaiseNavigationStopped(object content, Uri uri, NavigationMode mode)
    {
      NavigationStoppedEventHandler navigationStopped = this.NavigationStopped;
      this.IsNavigationInProgress = false;
      this.IsNavigationPending = false;
      if (navigationStopped == null)
        return;
      NavigationEventArgs e = new NavigationEventArgs(content, uri, mode, this.Host.Content != null);
      navigationStopped((object) this, e);
    }

    private void RaiseFragmentNavigation(string fragment)
    {
      FragmentNavigationEventHandler fragmentNavigation = this.FragmentNavigation;
      if (fragmentNavigation != null)
      {
        FragmentNavigationEventArgs e = new FragmentNavigationEventArgs(fragment);
        fragmentNavigation((object) this, e);
      }
      if (!(this._host.Content is IPhoneApplicationPage content))
        return;
      content.InternalOnFragmentNavigation(fragment);
    }

    private void ForceTextBindings()
    {
      if (!(FocusManager.GetFocusedElement() is FrameworkElement focusedElement))
        return;
      BindingExpression bindingExpression = (BindingExpression) null;
      if (focusedElement is TextBox)
        bindingExpression = focusedElement.GetBindingExpression(TextBox.TextProperty);
      else if (focusedElement is PasswordBox)
        bindingExpression = focusedElement.GetBindingExpression(PasswordBox.PasswordProperty);
      bindingExpression?.UpdateSource();
    }

    internal void RaiseJournalEntryRemoved(JournalEntry entry)
    {
      Guard.ArgumentNotNull((object) entry, nameof (entry));
      IPhoneApplicationPage pageInstance = entry.PageInstance;
      entry.PageInstance = (IPhoneApplicationPage) null;
      JournalEntryRemovedEventArgs e = new JournalEntryRemovedEventArgs(entry);
      EventHandler<JournalEntryRemovedEventArgs> journalEntryRemoved = this.JournalEntryRemoved;
      if (journalEntryRemoved != null)
        journalEntryRemoved((object) this, e);
      if (pageInstance == null)
        return;
      PerfUtil.InfoLogMarker(MarkerEvents.TH_ONNAVIGATIONREMOVED_PAGE, string.Format("{0}", (object) pageInstance));
      pageInstance.InternalOnRemovedFromJournal(entry.Name, entry.Source);
    }

    private class NavigationOperation
    {
      public NavigationOperation(
        Uri uri,
        Uri uriBeforeMapping,
        Uri uriForJournal,
        NavigationMode mode)
      {
        this.Uri = uri;
        this.UriBeforeMapping = uriBeforeMapping;
        this.UriForJournal = uriForJournal;
        this.Mode = mode;
      }

      public Uri Uri { get; set; }

      public Uri UriBeforeMapping { get; set; }

      public Uri UriForJournal { get; set; }

      public NavigationMode Mode { [SuppressMessage("Microsoft.Usage", "CA1811:AvoidUncalledPrivateCode", Justification = "Reserved for future")] get; set; }
    }
  }
}
