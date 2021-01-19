using System;

namespace ClassLibrary
{
    using System.Drawing;

    public class NineSplitter228 : Interface.IPlugin
    {
        public string Name => "Преобразование в ЧБ";

        public string Version => "1.10";

        public string Author => "The best author";

        public void Transform(Interface.IMainApp app)
        {
            var bitmap = app.Image;

            for (var i = 0; i < bitmap.Width; i++)
                for (var j = 0; j < bitmap.Height; j++)
                {
                    var p = bitmap.GetPixel(i, j);
                    var v = (p.R + p.G + p.B) / 3;
                    bitmap.SetPixel(i, j, Color.FromArgb(v, v, v));
                }

            app.Image = bitmap;
        }

    }
}
