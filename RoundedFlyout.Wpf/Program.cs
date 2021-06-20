using System;

namespace RoundedFlyout.Wpf
{
  public class Program
  {
    [STAThread]
    public static void Main()
    {
      using (new Uwp.App())
      {
        var app = new App();
        app.InitializeComponent();
        app.Run();
      }
    }
  }
}