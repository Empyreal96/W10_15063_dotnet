// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerServicesComponent
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class GamerServicesComponent : GameComponent
  {
    public GamerServicesComponent(Game game)
      : base(game)
    {
    }

    public override void Initialize()
    {
      GamerServicesDispatcher.WindowHandle = this.Game.Window.Handle;
      GamerServicesDispatcher.InstallingTitleUpdate += new EventHandler<EventArgs>(this.GamerServicesDispatcher_InstallingTitleUpdate);
      GamerServicesDispatcher.Initialize((IServiceProvider) this.Game.Services);
      base.Initialize();
    }

    public override void Update(GameTime gameTime)
    {
      GamerServicesDispatcher.Update();
      base.Update(gameTime);
    }

    private void GamerServicesDispatcher_InstallingTitleUpdate(object sender, EventArgs e) => this.Game.Exit();
  }
}
