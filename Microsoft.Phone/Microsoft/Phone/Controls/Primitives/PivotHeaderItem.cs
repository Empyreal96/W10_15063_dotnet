// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Primitives.PivotHeaderItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Automation.Peers;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;

namespace Microsoft.Phone.Controls.Primitives
{
  [TemplateVisualState(GroupName = "SelectionStates", Name = "Selected")]
  [TemplateVisualState(GroupName = "SelectionStates", Name = "Unselected")]
  public class PivotHeaderItem : ContentControl
  {
    private const string SelectedState = "Selected";
    private const string UnselectedState = "Unselected";
    private const string SelectionStatesGroup = "SelectionStates";
    public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register(nameof (IsSelected), typeof (bool), typeof (PivotHeaderItem), new PropertyMetadata((object) false, new PropertyChangedCallback(PivotHeaderItem.OnIsSelectedPropertyChanged)));

    public bool IsSelected
    {
      get => (bool) this.GetValue(PivotHeaderItem.IsSelectedProperty);
      set => this.SetValue(PivotHeaderItem.IsSelectedProperty, value);
    }

    private static void OnIsSelectedPropertyChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      PivotHeaderItem pivotHeaderItem = d as PivotHeaderItem;
      if (pivotHeaderItem.ParentHeadersControl == null)
        return;
      pivotHeaderItem.ParentHeadersControl.NotifyHeaderItemSelected(pivotHeaderItem, (bool) e.NewValue);
      pivotHeaderItem.UpdateVisualStates(true);
    }

    internal PivotHeadersControl ParentHeadersControl { get; set; }

    internal object Item { get; set; }

    public PivotHeaderItem()
    {
      this.DefaultStyleKey = (object) typeof (PivotHeaderItem);
      this.SetAutomaticBitmapCache();
    }

    protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
    {
      base.OnMouseLeftButtonUp(e);
      if (e == null || e.Handled)
        return;
      e.Handled = true;
      if (this.ParentHeadersControl == null)
        return;
      this.ParentHeadersControl.OnHeaderItemClicked(this);
    }

    protected override void OnContentChanged(object oldContent, object newContent)
    {
      base.OnContentChanged(oldContent, newContent);
      if (this.ParentHeadersControl == null)
        return;
      this.ParentHeadersControl.InvalidateMeasure();
    }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      this.UpdateVisualStates(false);
    }

    protected override AutomationPeer OnCreateAutomationPeer()
    {
      AutomationPeer automationPeer = (AutomationPeer) new PivotHeaderItemAutomationPeer(this);
      if (this.ParentHeadersControl != null)
      {
        PivotItem pivotItemForItem = this.ParentHeadersControl.GetPivotItemForItem(this.Item);
        if (pivotItemForItem != null)
        {
          AutomationPeer peerForElement = FrameworkElementAutomationPeer.CreatePeerForElement((UIElement) pivotItemForItem);
          if (peerForElement != null)
            automationPeer.SetAutomationPeerParent(peerForElement);
        }
      }
      return automationPeer;
    }

    internal void UpdateVisualStateToUnselected() => VisualStateManager.GoToState((Control) this, "Unselected", false);

    internal void RestoreVisualStates() => this.UpdateVisualStates(false);

    private void UpdateVisualStates(bool useTransitions) => VisualStateManager.GoToState((Control) this, this.IsSelected ? "Selected" : "Unselected", useTransitions);
  }
}
