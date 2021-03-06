// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBarIconButtonContainer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;

namespace Microsoft.Phone.Shell
{
  internal class ApplicationBarIconButtonContainer : ApplicationBarItemContainer
  {
    internal ApplicationBarIconButtonContainer(ApplicationBarIconButton item)
      : base((IApplicationBarMenuItem) item, MenuBarItemType.ImageButton)
    {
      this.ApplicationBarItem = item;
    }

    protected ApplicationBarIconButton ApplicationBarItem { get; set; }

    protected override void UpdateProperties(object sender, BoolEventArgs args)
    {
      this.IconUri = this.ApplicationBarItem.IconUri;
      base.UpdateProperties((object) this, args);
    }

    internal override void ClickEvent() => this.ApplicationBarItem.ClickEvent();

    internal override void BeginAttachToAppBar()
    {
      this.ApplicationBarItem.Changed += new EventHandler<BoolEventArgs>(((ApplicationBarItemContainer) this).UpdateProperties);
      base.BeginAttachToAppBar();
    }

    internal override void DetachFromAppBar()
    {
      base.DetachFromAppBar();
      this.ApplicationBarItem.Changed -= new EventHandler<BoolEventArgs>(((ApplicationBarItemContainer) this).UpdateProperties);
    }
  }
}
