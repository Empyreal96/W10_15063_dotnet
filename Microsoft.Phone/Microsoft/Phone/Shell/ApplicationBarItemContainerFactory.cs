// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ApplicationBarItemContainerFactory
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;

namespace Microsoft.Phone.Shell
{
  internal class ApplicationBarItemContainerFactory
  {
    internal static ApplicationBarItemContainer GetApplicationBarItemContainer(
      IApplicationBarMenuItem item,
      MenuBarItemType itemParentType)
    {
      ApplicationBarIconButton applicationBarIconButton = item as ApplicationBarIconButton;
      if (itemParentType != MenuBarItemType.TextItem && applicationBarIconButton != null)
        return (ApplicationBarItemContainer) new ApplicationBarIconButtonContainer(applicationBarIconButton);
      return item is ApplicationBarMenuItem || applicationBarIconButton != null ? (ApplicationBarItemContainer) new ApplicationBarMenuItemContainer(item) : throw new InvalidOperationException("This list does not support that type");
    }
  }
}
