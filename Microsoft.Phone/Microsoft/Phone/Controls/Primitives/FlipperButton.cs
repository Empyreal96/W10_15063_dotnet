// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Primitives.FlipperButton
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace Microsoft.Phone.Controls.Primitives
{
  internal class FlipperButton : Button
  {
    private const string c_flipperStyleXaml = "<Style xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' x:Key='PivotHeaderFlipper' TargetType='Button'><Setter Property='VerticalAlignment' Value='Center' /><Setter Property='Width' Value='0' /><Setter Property='Height' Value='0' /><Setter Property='Template'><Setter.Value><ControlTemplate TargetType='Button'><Grid x:Name='RootGrid' Background='{StaticResource PhoneFlipperBackgroundBrush}' Margin='0,0,-18,-40' ><VisualStateManager.VisualStateGroups><VisualStateGroup x:Name='CommonStates'><VisualState x:Name='Normal'><Storyboard><ObjectAnimationUsingKeyFrames Storyboard.TargetName='RootGrid' Storyboard.TargetProperty='Background'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperBackgroundBrush}' /></ObjectAnimationUsingKeyFrames><ObjectAnimationUsingKeyFrames Storyboard.TargetName='Text' Storyboard.TargetProperty='Foreground'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperForegroundBrush}' /></ObjectAnimationUsingKeyFrames></Storyboard></VisualState><VisualState x:Name='MouseOver'><Storyboard><ObjectAnimationUsingKeyFrames Storyboard.TargetName='RootGrid' Storyboard.TargetProperty='Background'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperBackgroundHoverBrush}' /></ObjectAnimationUsingKeyFrames><ObjectAnimationUsingKeyFrames Storyboard.TargetName='Text' Storyboard.TargetProperty='Foreground'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperForegroundHoverBrush}' /></ObjectAnimationUsingKeyFrames></Storyboard></VisualState><VisualState x:Name='Pressed' ><Storyboard><ObjectAnimationUsingKeyFrames Storyboard.TargetName='RootGrid' Storyboard.TargetProperty='Background'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperBackgroundPressedBrush}' /></ObjectAnimationUsingKeyFrames><ObjectAnimationUsingKeyFrames Storyboard.TargetName='Text' Storyboard.TargetProperty='Foreground'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperForegroundPressedBrush}' /></ObjectAnimationUsingKeyFrames></Storyboard></VisualState><VisualState x:Name='Disabled' /></VisualStateGroup></VisualStateManager.VisualStateGroups><TextBlock x:Name='Text' IsHitTestVisible='False' FontFamily='Segoe UI Symbol' Text='{TemplateBinding Content}' FontSize='16' Foreground='{StaticResource PhoneFlipperForegroundBrush}' HorizontalAlignment='Center' VerticalAlignment='Center'/></Grid></ControlTemplate></Setter.Value></Setter></Style>";
    private static Style s_flipperStyle;
    private static bool? s_forceMouseAffordances;
    internal const double FixedHeight = 40.0;
    internal const double FixedWidth = 18.0;

    public FlipperButton()
    {
      if (FlipperButton.s_flipperStyle == null)
        FlipperButton.s_flipperStyle = (Style) XamlReader.Load("<Style xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' x:Key='PivotHeaderFlipper' TargetType='Button'><Setter Property='VerticalAlignment' Value='Center' /><Setter Property='Width' Value='0' /><Setter Property='Height' Value='0' /><Setter Property='Template'><Setter.Value><ControlTemplate TargetType='Button'><Grid x:Name='RootGrid' Background='{StaticResource PhoneFlipperBackgroundBrush}' Margin='0,0,-18,-40' ><VisualStateManager.VisualStateGroups><VisualStateGroup x:Name='CommonStates'><VisualState x:Name='Normal'><Storyboard><ObjectAnimationUsingKeyFrames Storyboard.TargetName='RootGrid' Storyboard.TargetProperty='Background'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperBackgroundBrush}' /></ObjectAnimationUsingKeyFrames><ObjectAnimationUsingKeyFrames Storyboard.TargetName='Text' Storyboard.TargetProperty='Foreground'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperForegroundBrush}' /></ObjectAnimationUsingKeyFrames></Storyboard></VisualState><VisualState x:Name='MouseOver'><Storyboard><ObjectAnimationUsingKeyFrames Storyboard.TargetName='RootGrid' Storyboard.TargetProperty='Background'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperBackgroundHoverBrush}' /></ObjectAnimationUsingKeyFrames><ObjectAnimationUsingKeyFrames Storyboard.TargetName='Text' Storyboard.TargetProperty='Foreground'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperForegroundHoverBrush}' /></ObjectAnimationUsingKeyFrames></Storyboard></VisualState><VisualState x:Name='Pressed' ><Storyboard><ObjectAnimationUsingKeyFrames Storyboard.TargetName='RootGrid' Storyboard.TargetProperty='Background'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperBackgroundPressedBrush}' /></ObjectAnimationUsingKeyFrames><ObjectAnimationUsingKeyFrames Storyboard.TargetName='Text' Storyboard.TargetProperty='Foreground'><DiscreteObjectKeyFrame KeyTime='0' Value='{StaticResource PhoneFlipperForegroundPressedBrush}' /></ObjectAnimationUsingKeyFrames></Storyboard></VisualState><VisualState x:Name='Disabled' /></VisualStateGroup></VisualStateManager.VisualStateGroups><TextBlock x:Name='Text' IsHitTestVisible='False' FontFamily='Segoe UI Symbol' Text='{TemplateBinding Content}' FontSize='16' Foreground='{StaticResource PhoneFlipperForegroundBrush}' HorizontalAlignment='Center' VerticalAlignment='Center'/></Grid></ControlTemplate></Setter.Value></Setter></Style>");
      this.Style = FlipperButton.s_flipperStyle;
    }

    public static bool ShouldShowFlippers
    {
      get
      {
        if (!FlipperButton.s_forceMouseAffordances.HasValue)
        {
          uint propertyValue = 0;
          Registry.QueryDwordValue(2147483650U, "Software\\Microsoft\\Silverlight", "ForceMouseAffordances", ref propertyValue);
          FlipperButton.s_forceMouseAffordances = new bool?(propertyValue > 0U);
        }
        return FlipperButton.s_forceMouseAffordances.Value;
      }
    }

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) null;

    internal void RemoveFromTree()
    {
      if (!(VisualTreeHelper.GetParent((DependencyObject) this) is Panel parent))
        return;
      parent.Children.Remove((UIElement) this);
    }
  }
}
