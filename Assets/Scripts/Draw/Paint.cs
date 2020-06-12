using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FreeDraw
{
    public class Paint : MonoBehaviour
    {
        public static bool isCursorOverUI = false;
        public float Transparency = 1f;

        public void SetMarkerColour(Color new_color)
        {
            Board.Pen_Colour = new_color;
        }
        public void SetMarkerWidth(int new_width)
        {
            Board.Pen_Width = new_width;
        }
        public void SetMarkerWidth(float new_width)
        {
            SetMarkerWidth((int)new_width);
        }

        public void SetTransparency(float amount)
        {
            Transparency = amount;
            Color c = Board.Pen_Colour;
            c.a = amount;
            Board.Pen_Colour = c;
        }


        public void SetMarkerRed()
        {
            Color c = Color.red;
            c.a = Transparency;
            SetMarkerColour(c);
            Board.board.SetPenBrush();
        }
        public void SetMarkerGreen()
        {
            Color c = Color.green;
            c.a = Transparency;
            SetMarkerColour(c);
            Board.board.SetPenBrush();
        }
        public void SetMarkerBlue()
        {
            Color c = Color.blue;
            c.a = Transparency;
            SetMarkerColour(c);
            Board.board.SetPenBrush();
        }
        public void SetMarkerBlack()
        {
            Color c = Color.black;
            c.a = Transparency;
            SetMarkerColour(c);
            Board.board.SetPenBrush();
        }
        public void SetEraser()
        {
            SetMarkerColour(new Color(255f, 255f, 255f, 0f));
        }

        public void PartialSetEraser()
        {
            SetMarkerColour(new Color(255f, 255f, 255f, 0.5f));
        }
    }
}