// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.FullScreenPopup
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Microsoft.Phone.Controls
{
  internal class FullScreenPopup
  {
    private const byte BackgroundAlpha = 204;
    private bool _wasSystemTrayVisible;
    private bool _wasApplicationBarVisible;
    private bool _shouldResetSuppressTopMarginChange;
    private Popup _hostPopup;
    private Border _outerBorder;
    private PhoneApplicationPage _hostPage;
    private bool _isCancelled;

    public FullScreenPopup(bool setBackground)
    {
      this._outerBorder = new Border();
      if (setBackground)
      {
        Color color = Colors.Black;
        object resource = Application.Current.Resources[(object) "PhoneBackgroundColor"];
        if (resource != null)
          color = (Color) resource;
        color.A = (byte) 204;
        this._outerBorder.Background = (Brush) new SolidColorBrush(color);
      }
      this._hostPopup = new Popup();
      this._hostPopup.Child = (UIElement) this._outerBorder;
    }

    public void Show()
    {
      this.PrepareAppForFullScreen();
      this.SetOrientation();
      this._hostPopup.IsOpen = true;
    }

    public void Hide()
    {
      this._hostPopup.IsOpen = false;
      this.RestoreSettings();
    }

    public UIElement Child
    {
      get => this._outerBorder.Child;
      set => this._outerBorder.Child = value;
    }

    public event EventHandler PopupCancelled;

    private void PrepareAppForFullScreen()
    {
      PhoneApplicationFrame rootVisual = Application.Current.RootVisual as PhoneApplicationFrame;
      this._hostPage = (PhoneApplicationPage) null;
      if (rootVisual != null)
        this._hostPage = rootVisual.Content as PhoneApplicationPage;
      if (this._hostPage != null && this._hostPage.ApplicationBar != null && this._hostPage.ApplicationBar.IsVisible)
      {
        this._wasApplicationBarVisible = true;
        this._hostPage.ApplicationBar.IsVisible = false;
      }
      if (SystemTray.IsVisible)
      {
        if (this._hostPage != null && !this._hostPage.SuppressTopMarginChange)
        {
          this._shouldResetSuppressTopMarginChange = true;
          this._hostPage.SuppressTopMarginChange = true;
        }
        this._wasSystemTrayVisible = true;
        SystemTray.IsVisible = false;
      }
      if (rootVisual == null)
        return;
      rootVisual.BackKeyPressPreview += new EventHandler<CancelEventArgs>(this.OnBackKeyPressPreview);
      rootVisual.Navigating += new NavigatingCancelEventHandler(this.OnFrameNavigating);
      rootVisual.OrientationChanged += new EventHandler<OrientationChangedEventArgs>(this.OnOrientationChanged);
      Task rootTask1 = ApplicationHost.Current.RootTask;
      rootTask1.OnPause = rootTask1.OnPause + new ITask.Pause(this.OnPause);
      Task rootTask2 = ApplicationHost.Current.RootTask;
      rootTask2.OnRunningInBackground = rootTask2.OnRunningInBackground + new ITask.RunningInBackground(this.OnRunningInBackground);
    }

    private void RestoreSettings()
    {
      PhoneApplicationFrame rootVisual = Application.Current.RootVisual as PhoneApplicationFrame;
      if (this._wasApplicationBarVisible && this._hostPage != null && this._hostPage.ApplicationBar != null)
        this._hostPage.ApplicationBar.IsVisible = true;
      if (this._wasSystemTrayVisible)
      {
        if (this._hostPage != null && this._shouldResetSuppressTopMarginChange)
          this._hostPage.SuppressTopMarginChange = false;
        SystemTray.IsVisible = true;
      }
      if (rootVisual == null)
        return;
      rootVisual.BackKeyPressPreview -= new EventHandler<CancelEventArgs>(this.OnBackKeyPressPreview);
      rootVisual.Navigating -= new NavigatingCancelEventHandler(this.OnFrameNavigating);
      rootVisual.OrientationChanged -= new EventHandler<OrientationChangedEventArgs>(this.OnOrientationChanged);
      Task rootTask1 = ApplicationHost.Current.RootTask;
      rootTask1.OnPause = rootTask1.OnPause - new ITask.Pause(this.OnPause);
      Task rootTask2 = ApplicationHost.Current.RootTask;
      rootTask2.OnRunningInBackground = rootTask2.OnRunningInBackground - new ITask.RunningInBackground(this.OnRunningInBackground);
    }

    private void OnBackKeyPressPreview(object sender, CancelEventArgs args)
    {
      this.CancelPopup();
      args.Cancel = true;
    }

    private void OnFrameNavigating(object sender, NavigatingCancelEventArgs args) => this.CancelPopup();

    private void OnPause(uint unused) => this.CancelPopup();

    private void OnRunningInBackground() => this.CancelPopup();

    private void OnOrientationChanged(object sender, OrientationChangedEventArgs args) => this.SetOrientation();

    private void CancelPopup()
    {
      if (this._isCancelled)
        return;
      this._isCancelled = true;
      EventHandler popupCancelled = this.PopupCancelled;
      if (popupCancelled != null)
        popupCancelled((object) this, EventArgs.Empty);
      else
        this.Hide();
    }

    private void SetOrientation()
    {
      if (!(Application.Current.RootVisual is PhoneApplicationFrame rootVisual))
        return;
      PageOrientation orientation = rootVisual.Orientation;
      Transform transform = (Transform) null;
      double actualWidth = Application.Current.Host.Content.ActualWidth;
      double actualHeight = Application.Current.Host.Content.ActualHeight;
      double num1 = actualWidth;
      double num2 = actualHeight;
      switch (orientation)
      {
        case PageOrientation.Landscape:
        case PageOrientation.LandscapeLeft:
          transform = (Transform) new CompositeTransform()
          {
            Rotation = 90.0,
            TranslateX = actualWidth
          };
          num1 = actualHeight;
          num2 = actualWidth;
          break;
        case PageOrientation.LandscapeRight:
          transform = (Transform) new CompositeTransform()
          {
            Rotation = -90.0,
            TranslateY = actualHeight
          };
          num1 = actualHeight;
          num2 = actualWidth;
          break;
      }
      this._outerBorder.RenderTransform = transform;
      this._outerBorder.Width = num1;
      this._outerBorder.Height = num2;
    }
  }
}
