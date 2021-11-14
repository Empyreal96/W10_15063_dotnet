// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.Interop.NativeListInteropWrapper
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.Security;
using System.Windows;

namespace Microsoft.Phone.Shell.Interop
{
  [SecuritySafeCritical]
  internal class NativeListInteropWrapper : IListInterop
  {
    private object handleLock = new object();
    private IntPtr mAppBarHandle = IntPtr.Zero;
    private int mButtonCount;
    private int mItemCount;

    internal NativeListInteropWrapper(IntPtr nativeApplicationBar) => this.mAppBarHandle = nativeApplicationBar;

    internal void SetAppBarHandle(IntPtr handle)
    {
      lock (this.handleLock)
        this.mAppBarHandle = handle;
    }

    [SecuritySafeCritical]
    public void InsertMenuItem(int idCommand, MenuBarItemType type, int index)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.InsertMenuItem(idCommand, type, index)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          MenuItemData pMenuItemData = new MenuItemData();
          pMenuItemData.uType = type;
          pMenuItemData.dwId = (uint) idCommand;
          pMenuItemData.fEnabled = true;
          pMenuItemData.pszText = "";
          pMenuItemData.pszChecked = "";
          pMenuItemData.pszUnchecked = "";
          try
          {
            if (type.IsButton())
              ++this.mButtonCount;
            else
              ++this.mItemCount;
            NativeListMethods.InsertAppBarItem(this.mAppBarHandle, ref pMenuItemData, index);
          }
          catch (Exception ex)
          {
            throw new InvalidOperationException("Item could not be inserted", ex);
          }
        }
      }
    }

    [SecuritySafeCritical]
    public void RemoveMenuItem(MenuBarItemType type, int index)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.RemoveMenuItem(type, index)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          if (type.IsButton())
            --this.mButtonCount;
          else
            --this.mItemCount;
          NativeListMethods.RemoveAppBarItem(this.mAppBarHandle, (uint) index, type.IsButton());
        }
      }
    }

    [SecuritySafeCritical]
    public void SetMenuItem(
      int id,
      MenuBarItemType type,
      bool enabled,
      string validatedText,
      UriInteropWrapper validatedUri)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetMenuItem(id, type, enabled, validatedText, validatedUri)));
      }
      else
      {
        lock (this.handleLock)
        {
          if (!(this.mAppBarHandle != IntPtr.Zero))
            return;
          NativeListMethods.UpdateAppBarItem(this.mAppBarHandle, ref new MenuItemData()
          {
            uType = type,
            fEnabled = enabled,
            dwId = (uint) id,
            pszText = validatedText,
            pszChecked = "",
            pszUnchecked = this.GetPathForUri(validatedUri)
          }, (uint) id);
        }
      }
    }

    private string GetPathForUri(UriInteropWrapper validatedUri)
    {
      if (validatedUri == null)
        return (string) null;
      string appInstallFolder = ApplicationHost.Current.AppInstallFolder;
      string str;
      if (appInstallFolder != null && appInstallFolder.Length > 0)
      {
        if (!appInstallFolder.EndsWith("\\", StringComparison.InvariantCulture))
          appInstallFolder += "\\";
        str = appInstallFolder.Replace('\\', '/');
      }
      else
        str = "/";
      return "file://" + str + validatedUri.Uri.OriginalString;
    }

    [SecuritySafeCritical]
    public IList<int> GetIds()
    {
      IList<int> intList = (IList<int>) new List<int>();
      lock (this.handleLock)
      {
        if (this.mAppBarHandle != IntPtr.Zero)
        {
          MenuItemData pMenuItemData = new MenuItemData();
          pMenuItemData.uType = MenuBarItemType.ImageButton;
          for (uint uIndex = 0; (long) uIndex < (long) this.mButtonCount; ++uIndex)
          {
            NativeListMethods.GetAppBarItem(this.mAppBarHandle, ref pMenuItemData, uIndex);
            intList.Add((int) pMenuItemData.dwId);
          }
          pMenuItemData.uType = MenuBarItemType.TextItem;
          for (uint uIndex = 0; (long) uIndex < (long) this.mItemCount; ++uIndex)
          {
            NativeListMethods.GetAppBarItem(this.mAppBarHandle, ref pMenuItemData, uIndex);
            intList.Add((int) pMenuItemData.dwId);
          }
        }
      }
      return intList;
    }

    [SecuritySafeCritical]
    public bool GetProperties(
      int index,
      MenuBarItemType type,
      out string text,
      out string uri,
      out bool enabled)
    {
      bool flag = true;
      MenuItemData pMenuItemData = new MenuItemData();
      pMenuItemData.uType = type;
      text = "";
      uri = "";
      enabled = false;
      lock (this.handleLock)
      {
        if (this.mAppBarHandle != IntPtr.Zero)
        {
          NativeListMethods.GetAppBarItem(this.mAppBarHandle, ref pMenuItemData, (uint) index);
          text = pMenuItemData.pszText;
          uri = pMenuItemData.pszChecked;
          enabled = pMenuItemData.fEnabled;
        }
        else
          flag = false;
      }
      return flag;
    }
  }
}
