using BruTile;
using BruTile.Predefined;
using BruTile.Web;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace MapImagery
{
    public class ArcGISProvider
    {
        public ArcGISProvider()
        {

            var tileSource = new ArcGisTileSource("https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer", new GlobalSphericalMercator(0, 18));
            var extent = new Extent(-20037508, -20037508, 20037508, 20037508);
            var screenWidthInPixels = 400; // The width of the map on screen in pixels
            var resolution = extent.Width / screenWidthInPixels;
            var tileInfos = tileSource.Schema.GetTileInfos(extent, resolution);

            Console.WriteLine($"tiles:{tileInfos.Count()}");
            foreach (var tileInfo in tileInfos)
            {
                var tile = tileSource.GetTile(tileInfo);

                Console.WriteLine(
                    $"tile col: {tileInfo.Index.Col}, " +
                    $"tile row: {tileInfo.Index.Row}, " +
                    $"tile level: {tileInfo.Index.Level} , " +
                    $"tile size {tile.Length}");

                var dir = Path.Combine("cache", tileInfo.Index.Level.ToString(), tileInfo.Index.Col.ToString());
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                var path = Path.Combine(dir, tileInfo.Index.Row.ToString() + ".png");

                using (var img = Image.FromStream(new MemoryStream(tile)))
                {
                    img.Save(path);
                }
            }
        }
    }
}
