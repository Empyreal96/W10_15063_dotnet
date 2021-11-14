// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBarMenuItemContainer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;

namespace Microsoft.Phone.Shell
{
  internal class ApplicationBarMenuItemContainer : ApplicationBarItemContainer
  {
    internal ApplicationBarMenuItemContainer(IApplicationBarMenuItem item)
      : base(item, MenuBarItemType.TextItem)
    {
      this.ApplicationBarItem = item;
    }

    protected IApplicationBarMenuItem ApplicationBarItem { get; set; }

    internal override void ClickEvent()
    {
      if (this.ApplicationBarItem is ApplicationBarIconButton applicationBarItem2)
      {
        applicationBarItem2.ClickEvent();
      }
      else
      {
        if (!(this.ApplicationBarItem is ApplicationBarMenuItem applicationBarItem3))
          throw new InvalidOperationException("ApplicationBar menu item type not supported");
        applicationBarItem3.ClickEvent();
      }
    }

    internal override void BeginAttachToAppBar()
    {
      if (this.ApplicationBarItem is ApplicationBarIconButton applicationBarItem2)
      {
        applicationBarItem2.Changed += new EventHandler<BoolEventArgs>(((ApplicationBarItemContainer) this).UpdateProperties);
      }
      else
      {
        if (!(this.ApplicationBarItem is ApplicationBarMenuItem applicationBarItem3))
          throw new InvalidOperationException("ApplicationBar menu item type not supported");
        applicationBarItem3.Changed += new EventHandler<BoolEventArgs>(((ApplicationBarItemContainer) this).UpdateProperties);
      }
      base.BeginAttachToAppBar();
    }

    internal override void DetachFromAppBar()
    {
      base.DetachFromAppBar();
      if (this.ApplicationBarItem is ApplicationBarIconButton applicationBarItem2)
      {
        applicationBarItem2.Changed -= new EventHandler<BoolEventArgs>(((ApplicationBarItemContainer) this).UpdateProperties);
      }
      else
      {
        if (!(this.ApplicationBarItem is ApplicationBarMenuItem applicationBarItem3))
          throw new InvalidOperationException("ApplicationBar menu item type not supported");
        applicationBarItem3.Changed -= new EventHandler<BoolEventArgs>(((ApplicationBarItemContainer) this).UpdateProperties);
      }
    }
  }
}
