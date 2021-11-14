// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapPresentationContainer
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using MS.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapPresentationContainer : UserControl
  {
    private readonly SolidColorBrush defaultBackgroundColor = new SolidColorBrush(Colors.Transparent);
    private readonly Grid grid;
    private readonly ExternalInputContainer externalInputContainer;

    public MapPresentationContainer(FrameworkElement mapContent)
    {
      this.grid = new Grid();
      this.grid.Background = (Brush) this.defaultBackgroundColor;
      this.grid.Children.Add((UIElement) mapContent);
      this.externalInputContainer = new ExternalInputContainer();
      this.externalInputContainer.InputHandlerId = !Shim.UseUnifiedStack() ? 4 : 1;
      ((ContentControl) this.externalInputContainer).Content = (object) this.grid;
      this.Content = (UIElement) this.externalInputContainer;
    }

    public int InputInstanceId => this.externalInputContainer.InstanceId;

    public void AddChildren(UIElement uiElement) => this.grid.Children.Add(uiElement);

    public void RemoveChildren(UIElement uiElement) => this.grid.Children.Remove(uiElement);
  }
}
