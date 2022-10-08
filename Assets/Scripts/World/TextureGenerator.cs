using UnityEngine;

public static class TextureGenerator {

    public static Texture2D GetTexture(int width, int height, Tile[,] tiles) {
        var texture = new Texture2D(width, height);
        var pixels = new Color[width*height];

        for(var x = 0; x < width; x++) {
            for(var y = 0; y < height; y++) {
                float value = tiles[x,y].HeightValue;

                pixels[x + y * height] = Color.Lerp(Color.black, Color.white, value);
            }
        }
        texture.SetPixels(pixels);
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.Apply();
        return texture;
    }
}