// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.FakeExternalInputContainer
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Threading;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Microsoft.Phone.Maps.Controls
{
  internal class FakeExternalInputContainer : ContentControl
  {
    private static int idSeed;

    public FakeExternalInputContainer()
    {
      this.InstanceId = Interlocked.Add(ref FakeExternalInputContainer.idSeed, 1);
      this.LoadTemplate();
    }

    public int InputHandlerId { get; set; }

    public int InstanceId { get; set; }

    public void LoadTemplate() => this.Template = XamlReader.Load("<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' TargetType='ContentControl' >   <Grid>         <Border x:Name='border' BorderBrush='Green' BorderThickness='0' Background='{TemplateBinding Background}'>             <ContentPresenter />         </Border>   </Grid></ControlTemplate>") as ControlTemplate;
  }
}
