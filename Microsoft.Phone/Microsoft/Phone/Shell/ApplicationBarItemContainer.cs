// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBarItemContainer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;
using System.Windows;

namespace Microsoft.Phone.Shell
{
  internal class ApplicationBarItemContainer
  {
    private const int UnassignedID = -1;
    internal static readonly int MAX_TEXT_LENGTH = (int) byte.MaxValue;
    private int mIdCommand;
    private IListInterop mListInterop;
    private string mText;
    private bool mEnabled;
    private Uri mIconUri;
    private UriInteropWrapper mRealUri;
    protected IApplicationBarMenuItem mAppBarItem;
    private MenuBarItemType mType;

    internal static bool NullSafeCompare(object a, object b)
    {
      if (a == null && b == null)
        return true;
      return a != null && b != null && a.Equals(b);
    }

    internal IListInterop ListInterop
    {
      get => this.mListInterop;
      private set => this.mListInterop = value;
    }

    private void UpdateMenuItem()
    {
      if (this.mListInterop == null)
        return;
      this.mListInterop.SetMenuItem(this.IdCommand, this.Type, this.IsEnabled, this.Text, this.RealUri);
    }

    protected bool IsEnabled
    {
      get => this.mEnabled;
      set
      {
        if (value == this.mEnabled)
          return;
        this.mEnabled = value;
        this.UpdateMenuItem();
      }
    }

    protected string Text
    {
      get => this.mText;
      set
      {
        if (string.IsNullOrEmpty(value))
          throw new InvalidOperationException("Text cannot be empty.");
        string str = !value.Contains("\n") && !value.Contains("\r") ? value.Trim() : throw new InvalidOperationException("Text cannot contain multiple lines");
        if (str.Length == 0)
          throw new InvalidOperationException("Text cannot be only white space.");
        if (ApplicationBarItemContainer.NullSafeCompare((object) this.mText, (object) str))
          return;
        if (str != null && str.Length > ApplicationBarItemContainer.MAX_TEXT_LENGTH)
          throw new ArgumentOutOfRangeException(nameof (value), "Text cannot be longer than maximum allowed length.");
        this.mText = str;
        this.UpdateMenuItem();
      }
    }

    protected Uri IconUri
    {
      get => this.mIconUri;
      set
      {
        if (value == (Uri) null)
          throw new ArgumentNullException(nameof (value), "Cannot clear the icon while in a list");
        if (ApplicationBarItemContainer.NullSafeCompare((object) value, (object) this.mIconUri))
          return;
        if (this.mRealUri == null)
          this.mRealUri = new UriInteropWrapper();
        this.mRealUri.Uri = value;
        this.mIconUri = value;
        this.UpdateMenuItem();
      }
    }

    private UriInteropWrapper RealUri => this.mRealUri;

    internal int IdCommand
    {
      get => this.mIdCommand;
      private set => this.mIdCommand = value;
    }

    internal MenuBarItemType Type => this.mType;

    internal ApplicationBarItemContainer(IApplicationBarMenuItem item, MenuBarItemType type)
    {
      this.mAppBarItem = item;
      this.mIdCommand = -1;
      this.mType = type;
    }

    protected virtual void UpdateProperties(object sender, BoolEventArgs args)
    {
      this.IsEnabled = this.mAppBarItem.IsEnabled;
      this.Text = this.mAppBarItem.Text;
      args.Success = true;
    }

    internal void AttachToAppBar(IListInterop listInterop, int idCommand)
    {
      this.ListInterop = listInterop;
      this.IdCommand = idCommand;
      this.UpdateMenuItem();
    }

    internal virtual void BeginAttachToAppBar() => this.UpdateProperties((object) null, new BoolEventArgs());

    internal virtual void DetachFromAppBar()
    {
      this.ListInterop = (IListInterop) null;
      this.IdCommand = -1;
    }

    internal virtual void ClickEvent()
    {
    }

    internal static void FireEventHandler(EventHandler handler, object sender, EventArgs args)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => ApplicationBarItemContainer.FireEventHandler(handler, sender, args)));
      }
      else
      {
        EventHandler eventHandler = handler;
        if (eventHandler == null)
          return;
        eventHandler(sender, args);
      }
    }
  }
}
