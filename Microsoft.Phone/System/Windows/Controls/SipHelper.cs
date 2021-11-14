// Decompiled with JetBrains decompiler
// Type: System.Windows.Controls.SipHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace System.Windows.Controls
{
  internal static class SipHelper
  {
    private static double _bottomMargin;
    private static TextBox _textBox;
    private static bool _elementAdjusted;
    private const double _sipBuffer = 45.0;
    private const double _duration = 500.0;
    private const double _power = 7.0;

    private static void AdjustFrame(
      FrameworkElement element,
      double bottomMargin,
      out double stillObscured)
    {
      stillObscured = 0.0;
      IPhoneApplicationFrame rootVisual = Application.Current.RootVisual as IPhoneApplicationFrame;
      IPhoneApplicationPage content1 = rootVisual.Content as IPhoneApplicationPage;
      double appBarSize = rootVisual.RotateOnClientArea ? 0.0 : content1.GetBottomChromeElementsHeightWithoutSIP();
      if (rootVisual == null || !element.IsInLiveTree)
        return;
      Content content2 = Application.Current.Host.Content;
      double frameHeight = rootVisual.RotateOnClientArea ? content2.ActualWidth : content2.ActualHeight;
      Size renderSize;
      double num1;
      if (!(element is WebBrowserBase webBrowserBase))
      {
        renderSize = element.RenderSize;
        num1 = renderSize.Height;
      }
      else
        num1 = webBrowserBase.GetMinimumEditActivationHeight();
      double num2 = num1;
      GeneralTransform visual = element.TransformToVisual(rootVisual as UIElement);
      GeneralTransform generalTransform1 = visual;
      double verticalOffset1 = rootVisual.VerticalOffset;
      renderSize = element.RenderSize;
      double width1 = renderSize.Width;
      double height1 = num2;
      Rect rect1 = new Rect(0.0, verticalOffset1, width1, height1);
      Rect elementBounds = generalTransform1.TransformBounds(rect1);
      TextBox textBox = element as TextBox;
      double y = webBrowserBase != null ? 0.0 : 45.0;
      Rect visibleBounds = new Rect(0.0, y, 0.0, Math.Max(0.0, frameHeight - bottomMargin - y * 2.0));
      double num3 = 0.0;
      if ((elementBounds.Bottom > visibleBounds.Bottom || elementBounds.Top < visibleBounds.Top || SipHelper._elementAdjusted) && visibleBounds.Height != 0.0)
      {
        if (elementBounds.Height < visibleBounds.Height)
          num3 = elementBounds.Top >= visibleBounds.Top ? SipHelper.GetBottomTranslationDelta(appBarSize, rootVisual.VerticalOffset, bottomMargin, frameHeight, visibleBounds, elementBounds) : visibleBounds.Top - elementBounds.Top;
        else if (textBox != null)
        {
          int selectionStart = SipHelper._textBox.SelectionStart;
          int selectionLength = SipHelper._textBox.SelectionLength;
          Rect fromCharacterIndex = SipHelper._textBox.GetRectFromCharacterIndex(selectionStart + selectionLength, true);
          fromCharacterIndex.X += elementBounds.Left;
          fromCharacterIndex.Y += elementBounds.Top;
          if (fromCharacterIndex.Top < visibleBounds.Top)
            num3 = visibleBounds.Top - fromCharacterIndex.Top;
          else if (fromCharacterIndex.Bottom > visibleBounds.Bottom)
            num3 = visibleBounds.Bottom - fromCharacterIndex.Bottom;
        }
        else
          num3 = SipHelper.GetBottomTranslationDelta(appBarSize, rootVisual.VerticalOffset, bottomMargin, frameHeight, visibleBounds, elementBounds);
      }
      SipHelper._elementAdjusted = num3 != 0.0;
      double newOffset = Math.Max(Math.Min(rootVisual.VerticalOffset + num3, 0.0), -bottomMargin);
      if (webBrowserBase != null)
      {
        double normalHeight = webBrowserBase.GetNormalHeight();
        GeneralTransform generalTransform2 = visual;
        double verticalOffset2 = rootVisual.VerticalOffset;
        renderSize = element.RenderSize;
        double width2 = renderSize.Width;
        double height2 = normalHeight;
        Rect rect2 = new Rect(0.0, verticalOffset2, width2, height2);
        Rect rect3 = generalTransform2.TransformBounds(rect2);
        double num4 = newOffset - rootVisual.VerticalOffset;
        stillObscured = rect3.Bottom - visibleBounds.Bottom + num4;
        stillObscured = Math.Max(0.0, stillObscured);
      }
      SipHelper.StartFrameAnimation(rootVisual, newOffset, TimeSpan.FromMilliseconds(500.0));
    }

    internal static void FlickIn(FrameworkElement element, double bottomMargin)
    {
      if (SipHelper._textBox != null)
      {
        SipHelper._textBox.SelectionChanged -= new RoutedEventHandler(SipHelper.SelectionChanged);
        SipHelper._textBox = (TextBox) null;
      }
      SipHelper._textBox = element as TextBox;
      if (SipHelper._textBox != null)
        SipHelper._textBox.SelectionChanged += new RoutedEventHandler(SipHelper.SelectionChanged);
      SipHelper._bottomMargin = bottomMargin;
      double stillObscured;
      SipHelper.AdjustFrame(element, SipHelper._bottomMargin, out stillObscured);
      if (!(FocusManager.GetFocusedElement() is WebBrowserBase focusedElement))
        return;
      focusedElement.OnGotSipFocusFromYamanotePage(stillObscured);
    }

    internal static void FlickOut()
    {
      if (Application.Current.RootVisual is IPhoneApplicationFrame rootVisual)
        SipHelper.StartFrameAnimation(rootVisual, 0.0, TimeSpan.FromMilliseconds(500.0));
      if (SipHelper._textBox != null)
      {
        SipHelper._textBox.SelectionChanged -= new RoutedEventHandler(SipHelper.SelectionChanged);
        SipHelper._textBox = (TextBox) null;
      }
      if (FocusManager.GetFocusedElement() is WebBrowserBase focusedElement)
        focusedElement.OnLostSipFocusFromYamanotePage();
      SipHelper._elementAdjusted = false;
    }

    private static void SelectionChanged(object sender, RoutedEventArgs e) => SipHelper.AdjustFrame((FrameworkElement) SipHelper._textBox, SipHelper._bottomMargin, out double _);

    private static void StartFrameAnimation(
      IPhoneApplicationFrame frame,
      double newOffset,
      TimeSpan period)
    {
      if (frame.VerticalOffset == newOffset)
        return;
      Duration duration = new Duration(period);
      PowerEase powerEase = new PowerEase();
      powerEase.EasingMode = EasingMode.EaseOut;
      powerEase.Power = 7.0;
      DoubleAnimation doubleAnimation = new DoubleAnimation();
      doubleAnimation.To = new double?(newOffset);
      doubleAnimation.Duration = duration;
      doubleAnimation.EasingFunction = (IEasingFunction) powerEase;
      Storyboard.SetTarget((Timeline) doubleAnimation, frame as DependencyObject);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation, new PropertyPath("VerticalOffset", new object[0]));
      Storyboard storyboard = new Storyboard();
      storyboard.Duration = duration;
      storyboard.Children.Add((Timeline) doubleAnimation);
      storyboard.Begin();
    }

    private static double GetBottomTranslationDelta(
      double appBarSize,
      double frameVerticalOffset,
      double bottomMargin,
      double frameHeight,
      Rect visibleBounds,
      Rect elementBounds)
    {
      double num1 = frameHeight - elementBounds.Bottom - appBarSize + frameVerticalOffset;
      double num2;
      if (num1 < 0.0)
      {
        num2 = -bottomMargin + appBarSize - frameVerticalOffset;
      }
      else
      {
        double num3 = num1 < 45.0 ? 45.0 - num1 : 0.0;
        num2 = visibleBounds.Bottom - elementBounds.Bottom + num3;
      }
      return num2;
    }
  }
}
