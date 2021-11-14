// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBarIconButton
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Shell
{
  public class ApplicationBarIconButton : IApplicationBarIconButton, IApplicationBarMenuItem
  {
    private string mText;
    private bool mEnabled;
    private Uri mIconUri;

    internal event EventHandler<BoolEventArgs> Changed;

    public event EventHandler Click;

    public Uri IconUri
    {
      get => this.mIconUri;
      set
      {
        Uri mIconUri = this.mIconUri;
        if (ApplicationBarItemContainer.NullSafeCompare((object) this.mIconUri, (object) value))
          return;
        this.mIconUri = value;
        this.UpdateOrRevert((object) mIconUri, (object) this.mIconUri);
      }
    }

    public bool IsEnabled
    {
      get => this.mEnabled;
      set
      {
        bool mEnabled = this.mEnabled;
        if (value == this.mEnabled)
          return;
        this.mEnabled = value;
        this.UpdateOrRevert((object) mEnabled, (object) this.mEnabled);
      }
    }

    public string Text
    {
      get => this.mText;
      set
      {
        string mText = this.mText;
        if (ApplicationBarItemContainer.NullSafeCompare((object) this.mText, (object) value))
          return;
        this.mText = value;
        this.UpdateOrRevert((object) mText, (object) this.mText);
      }
    }

    public ApplicationBarIconButton()
      : this((Uri) null)
    {
    }

    public ApplicationBarIconButton(Uri iconUri)
    {
      this.IconUri = iconUri;
      this.IsEnabled = true;
    }

    internal void UpdateOrRevert(object original, object field)
    {
      EventHandler<BoolEventArgs> changed = this.Changed;
      BoolEventArgs e = new BoolEventArgs();
      try
      {
        if (changed == null)
          return;
        changed((object) this, e);
      }
      finally
      {
        if (!e.Success)
          field = original;
      }
    }

    internal void ClickEvent() => ApplicationBarItemContainer.FireEventHandler(this.Click, (object) this, EventArgs.Empty);
  }
}
