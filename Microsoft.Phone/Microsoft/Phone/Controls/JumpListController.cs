// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.JumpListController
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Controls
{
  internal class JumpListController
  {
    private Action<LongListSelector> _jumpListOpeningCallback;
    private Action<object> _jumpListClosingCallback;
    private Action _jumpListClosedCallback;
    private Storyboard _openAnimationStoryboard;
    private bool _openAnimationRequested;
    private bool _openAnimationStarted;
    private PlaneProjection _contentProjection;
    private LongListSelector _jumpListSelector;
    private FullScreenPopup _popup;
    private bool _isHiding;
    private FlowDirection _flowDirection;
    private const double FlipInInitialAngle = -45.0;
    private const double FlipOutFinalAngle = 90.0;
    private static readonly TimeSpan FadeInDuration = TimeSpan.FromSeconds(0.01);
    private static readonly TimeSpan FlipInDuration = TimeSpan.FromSeconds(0.35);
    private static readonly TimeSpan HideDuration = TimeSpan.FromSeconds(0.25);
    private static readonly KeyTime FadeOutKeyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.24));
    private static readonly KeyTime FadeOutKeyTime2 = KeyTime.FromTimeSpan(JumpListController.HideDuration);
    private static readonly PropertyPath OpacityPropertyPath = new PropertyPath("Opacity", new object[0]);
    private static readonly PropertyPath RotationXPropertyPath = new PropertyPath("RotationX", new object[0]);
    private static readonly IEasingFunction FlipInEase = (IEasingFunction) new ExponentialEase()
    {
      Exponent = 0.4
    };
    private static readonly IEasingFunction FlipOutEase = (IEasingFunction) new ExponentialEase()
    {
      Exponent = 1.5
    };

    public JumpListController(
      IList itemsSource,
      Style jumpListStyle,
      Action<LongListSelector> jumpListOpeningCallback,
      Action<object> jumpListClosingCallback,
      Action jumpListClosedCallback,
      FlowDirection fd)
    {
      this._jumpListSelector = new LongListSelector();
      this._jumpListSelector.IsGroupingEnabled = false;
      this._jumpListSelector.ItemsSource = itemsSource;
      this._jumpListSelector.Style = jumpListStyle;
      this._jumpListOpeningCallback = jumpListOpeningCallback;
      this._jumpListClosingCallback = jumpListClosingCallback;
      this._jumpListClosedCallback = jumpListClosedCallback;
      this._flowDirection = fd;
    }

    public void BeginOpen()
    {
      this._openAnimationStoryboard = new Storyboard();
      this._contentProjection = new PlaneProjection();
      this._contentProjection.RotationX = -45.0;
      this.AssignFlipInAnimation(this._contentProjection);
      this._jumpListSelector.ItemRealized += new EventHandler<ItemRealizationEventArgs>(this.OnNewItemRealized);
      this._jumpListSelector.SelectionChanged += new SelectionChangedEventHandler(this.OnSelectionChanged);
      if (this._jumpListSelector.ItemsSource != null && this._jumpListSelector.ItemsSource.Count > 1 && !JumpListController.HasItems(this._jumpListSelector.ItemsSource[0]))
      {
        foreach (object obj in (IEnumerable) this._jumpListSelector.ItemsSource)
        {
          if (JumpListController.HasItems(obj))
          {
            this._jumpListSelector.InitialItem = obj;
            break;
          }
        }
      }
      this._jumpListOpeningCallback(this._jumpListSelector);
      bool setBackground = true;
      if (this._jumpListSelector.Background != null && (!(this._jumpListSelector.Background is SolidColorBrush background) || background.Color != Colors.Transparent))
        setBackground = false;
      this._popup = new FullScreenPopup(setBackground);
      this._popup.Child = (UIElement) this._jumpListSelector;
      this._jumpListSelector.FlowDirection = this._flowDirection;
      this._popup.PopupCancelled += (EventHandler) ((sender, args) => this.BeginHide((object) null));
      this._popup.Show();
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      this._jumpListSelector.SelectionChanged -= new SelectionChangedEventHandler(this.OnSelectionChanged);
      this.BeginHide(this._jumpListSelector.SelectedItem);
    }

    private void BeginHide(object selectedItem)
    {
      if (this._isHiding)
        return;
      this._isHiding = true;
      Storyboard sb = new Storyboard();
      foreach (UIElement childElement in this._jumpListSelector.ChildElements)
      {
        childElement.Projection = (Projection) this._contentProjection;
        this.AssignFadeOutAnimation(sb, childElement);
      }
      this.AssignFlipOutAnimation(sb, this._contentProjection);
      sb.Duration = (Duration) JumpListController.HideDuration;
      sb.Completed += (EventHandler) ((sender, args) => this.EndHide(selectedItem));
      sb.Begin();
      this._jumpListClosingCallback(selectedItem);
    }

    private void EndHide(object selectedItem)
    {
      this._popup.Hide();
      this._jumpListClosedCallback();
    }

    private void OnNewItemRealized(object sender, ItemRealizationEventArgs e)
    {
      if (!this._openAnimationRequested)
      {
        Application.Current.RootVisual.Dispatcher.BeginInvoke((Action) (() =>
        {
          this._openAnimationStoryboard.Begin();
          this._openAnimationStarted = true;
        }));
        this._openAnimationRequested = true;
      }
      if (this._openAnimationStoryboard != null && e.Container.Projection == null && !this._openAnimationStarted)
      {
        e.Container.Projection = (Projection) this._contentProjection;
        this.AssignFadeInAnimation((UIElement) e.Container);
      }
      e.Container.IsHitTestVisible = JumpListController.HasItems(e.Container.Content);
    }

    private void AssignFadeInAnimation(UIElement presenter)
    {
      DoubleAnimation doubleAnimation = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation, (DependencyObject) presenter);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation, JumpListController.OpacityPropertyPath);
      doubleAnimation.From = new double?(0.0);
      doubleAnimation.To = new double?(1.0);
      doubleAnimation.Duration = (Duration) JumpListController.FadeInDuration;
      this._openAnimationStoryboard.Children.Add((Timeline) doubleAnimation);
    }

    private void AssignFlipInAnimation(PlaneProjection projection)
    {
      DoubleAnimation doubleAnimation = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation, (DependencyObject) projection);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation, JumpListController.RotationXPropertyPath);
      doubleAnimation.From = new double?(-45.0);
      doubleAnimation.To = new double?(0.0);
      doubleAnimation.Duration = (Duration) JumpListController.FlipInDuration;
      doubleAnimation.EasingFunction = JumpListController.FlipInEase;
      this._openAnimationStoryboard.Children.Add((Timeline) doubleAnimation);
    }

    private void AssignFadeOutAnimation(Storyboard sb, UIElement presenter)
    {
      DoubleAnimationUsingKeyFrames animationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
      Storyboard.SetTarget((Timeline) animationUsingKeyFrames, (DependencyObject) presenter);
      Storyboard.SetTargetProperty((Timeline) animationUsingKeyFrames, JumpListController.OpacityPropertyPath);
      DoubleKeyFrame doubleKeyFrame1 = (DoubleKeyFrame) new LinearDoubleKeyFrame();
      doubleKeyFrame1.KeyTime = JumpListController.FadeOutKeyTime1;
      doubleKeyFrame1.Value = 1.0;
      animationUsingKeyFrames.KeyFrames.Add(doubleKeyFrame1);
      DoubleKeyFrame doubleKeyFrame2 = (DoubleKeyFrame) new LinearDoubleKeyFrame();
      doubleKeyFrame2.KeyTime = JumpListController.FadeOutKeyTime2;
      doubleKeyFrame2.Value = 0.0;
      animationUsingKeyFrames.KeyFrames.Add(doubleKeyFrame2);
      sb.Children.Add((Timeline) animationUsingKeyFrames);
    }

    private void AssignFlipOutAnimation(Storyboard sb, PlaneProjection projection)
    {
      DoubleAnimation doubleAnimation = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation, (DependencyObject) projection);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation, JumpListController.RotationXPropertyPath);
      doubleAnimation.From = new double?(0.0);
      doubleAnimation.To = new double?(90.0);
      doubleAnimation.Duration = (Duration) JumpListController.HideDuration;
      doubleAnimation.EasingFunction = JumpListController.FlipOutEase;
      sb.Children.Add((Timeline) doubleAnimation);
    }

    private static bool HasItems(object item)
    {
      IEnumerable enumerable = item as IEnumerable;
      bool flag = false;
      if (enumerable != null)
      {
        IEnumerator enumerator = enumerable.GetEnumerator();
        if (enumerator != null)
          flag = enumerator.MoveNext();
      }
      return flag;
    }
  }
}
