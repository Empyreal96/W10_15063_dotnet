// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.IPhoneApplicationPage
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.ComponentModel;
using System.Windows.Navigation;

namespace Microsoft.Phone.Controls
{
  internal interface IPhoneApplicationPage
  {
    bool IsBackground { get; }

    object AppBar { get; }

    double GetApplicationBarSize();

    double GetNavBarPushUpHeight();

    double GetBottomChromeElementsHeightWithoutSIP();

    bool Focus();

    NavigationCacheMode NavigationCacheMode { get; }

    void InternalOnNavigatedToX(NavigationEventArgs e);

    void InternalOnNavigatingFromX(NavigatingCancelEventArgs e);

    void InternalOnNavigatedFromX(NavigationEventArgs e);

    void InternalOnBackKeyPress(CancelEventArgs e);

    void InternalOnRemovedFromJournal(string name, Uri removedPageUri);

    void SetAppChromeProperties();

    void InternalOnUIOrientationChange(Orientations orientation);

    void InternalOnFragmentNavigation(string fragment);

    event EventHandler<OrientationChangedEventArgs> BeginLayoutChanged;

    event EventHandler<OrientationChangedEventArgs> BeginOrientationChanged;

    event EventHandler<OrientationChangedEventArgs> OrientationChanged;

    event EventHandler<CancelEventArgs> BackKeyPress;

    event EventHandler<VisibleRegionChangeEventArgs> InternalVisibleRegionChanged;
  }
}
