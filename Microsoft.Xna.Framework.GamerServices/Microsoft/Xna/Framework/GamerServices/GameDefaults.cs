// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GameDefaults
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class GameDefaults
  {
    private GameDifficulty gameDifficulty;
    private ControllerSensitivity controllerSensitivity;
    private Color? primaryColor;
    private Color? secondaryColor;
    private bool autoAim;
    private bool autoCenter;
    private bool moveWithRightThumbStick;
    private bool invertYAxis;
    private bool manualTransmission;
    private RacingCameraAngle racingCameraAngle;
    private bool accelerateWithButtons;
    private bool brakeWithButtons;

    internal GameDefaults()
    {
    }

    public GameDifficulty GameDifficulty
    {
      get => this.gameDifficulty;
      internal set => this.gameDifficulty = value;
    }

    public ControllerSensitivity ControllerSensitivity
    {
      get => this.controllerSensitivity;
      internal set => this.controllerSensitivity = value;
    }

    public Color? PrimaryColor
    {
      get => this.primaryColor;
      internal set => this.primaryColor = value;
    }

    public Color? SecondaryColor
    {
      get => this.secondaryColor;
      internal set => this.secondaryColor = value;
    }

    public bool AutoAim
    {
      get => this.autoAim;
      internal set => this.autoAim = value;
    }

    public bool AutoCenter
    {
      get => this.autoCenter;
      internal set => this.autoCenter = value;
    }

    public bool MoveWithRightThumbStick
    {
      get => this.moveWithRightThumbStick;
      internal set => this.moveWithRightThumbStick = value;
    }

    public bool InvertYAxis
    {
      get => this.invertYAxis;
      internal set => this.invertYAxis = value;
    }

    public bool ManualTransmission
    {
      get => this.manualTransmission;
      internal set => this.manualTransmission = value;
    }

    public RacingCameraAngle RacingCameraAngle
    {
      get => this.racingCameraAngle;
      internal set => this.racingCameraAngle = value;
    }

    public bool AccelerateWithButtons
    {
      get => this.accelerateWithButtons;
      internal set => this.accelerateWithButtons = value;
    }

    public bool BrakeWithButtons
    {
      get => this.brakeWithButtons;
      internal set => this.brakeWithButtons = value;
    }
  }
}
