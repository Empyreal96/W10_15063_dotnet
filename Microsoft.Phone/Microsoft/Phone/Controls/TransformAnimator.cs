// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.TransformAnimator
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Controls
{
  internal sealed class TransformAnimator
  {
    private static readonly PropertyPath TranslateXPropertyPath = new PropertyPath("X", new object[0]);
    private readonly Storyboard _sbRunning = new Storyboard();
    private readonly DoubleAnimation _daRunning = new DoubleAnimation();
    private TranslateTransform _transform;
    private Action _oneTimeAction;

    public TransformAnimator(TranslateTransform translateTransform)
    {
      this._transform = translateTransform;
      this._sbRunning.Completed += new EventHandler(this.OnCompleted);
      this._sbRunning.Children.Add((Timeline) this._daRunning);
      Storyboard.SetTarget((Timeline) this._daRunning, (DependencyObject) this._transform);
      Storyboard.SetTargetProperty((Timeline) this._daRunning, TransformAnimator.TranslateXPropertyPath);
    }

    public double CurrentOffset => this._transform.X;

    public void GoTo(double targetOffset, Duration duration) => this.GoTo(targetOffset, duration, (IEasingFunction) null, (Action) null);

    public void GoTo(double targetOffset, Duration duration, Action completionAction) => this.GoTo(targetOffset, duration, (IEasingFunction) null, completionAction);

    public void GoTo(double targetOffset, Duration duration, IEasingFunction easingFunction) => this.GoTo(targetOffset, duration, easingFunction, (Action) null);

    public void GoTo(
      double targetOffset,
      Duration duration,
      IEasingFunction easingFunction,
      Action completionAction)
    {
      this._daRunning.To = new double?(targetOffset);
      this._daRunning.Duration = duration;
      this._daRunning.EasingFunction = easingFunction;
      this._sbRunning.Begin();
      this._sbRunning.SeekAlignedToLastTick(TimeSpan.Zero);
      this._oneTimeAction = completionAction;
    }

    public void UpdateEasingFunction(IEasingFunction ease)
    {
      if (this._daRunning == null || this._daRunning.EasingFunction == ease)
        return;
      this._daRunning.EasingFunction = ease;
    }

    public void UpdateDuration(Duration duration)
    {
      if (this._daRunning == null)
        return;
      this._daRunning.Duration = duration;
    }

    private void OnCompleted(object sender, EventArgs e)
    {
      Action oneTimeAction = this._oneTimeAction;
      if (oneTimeAction == null || this._sbRunning.GetCurrentState() == ClockState.Active)
        return;
      this._oneTimeAction = (Action) null;
      oneTimeAction();
    }

    public static void EnsureAnimator(
      FrameworkElement targetElement,
      ref TransformAnimator animator)
    {
      if (animator == null)
      {
        TranslateTransform translateTransform = TransformAnimator.GetTranslateTransform((UIElement) targetElement);
        if (translateTransform != null)
          animator = new TransformAnimator(translateTransform);
      }
      if (animator == null)
        throw new InvalidOperationException("The animation system could not be prepared for the target element.");
    }

    public static TranslateTransform GetTranslateTransform(UIElement container)
    {
      if (container == null)
        throw new ArgumentNullException(nameof (container));
      if (!(container.RenderTransform is TranslateTransform translateTransform))
      {
        if (container.RenderTransform == null)
        {
          translateTransform = new TranslateTransform();
          container.RenderTransform = (Transform) translateTransform;
        }
        else if (container.RenderTransform is TransformGroup)
        {
          TransformGroup renderTransform = container.RenderTransform as TransformGroup;
          translateTransform = ((IEnumerable<TranslateTransform>) Enumerable.Select<Transform, TranslateTransform>(Enumerable.Where<Transform>((IEnumerable<M0>) renderTransform.Children, (Func<M0, bool>) (t => t is TranslateTransform)), (Func<M0, M1>) (t => (TranslateTransform) t))).FirstOrDefault<TranslateTransform>();
          if (translateTransform == null)
          {
            translateTransform = new TranslateTransform();
            renderTransform.Children.Add((Transform) translateTransform);
          }
        }
        else
        {
          TransformGroup transformGroup = new TransformGroup();
          Transform renderTransform = container.RenderTransform;
          container.RenderTransform = (Transform) null;
          transformGroup.Children.Add(renderTransform);
          translateTransform = new TranslateTransform();
          transformGroup.Children.Add((Transform) translateTransform);
          container.RenderTransform = (Transform) transformGroup;
        }
      }
      return translateTransform;
    }
  }
}
