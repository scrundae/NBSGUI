using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Numerics;
using System.Net.Http.Headers;

namespace NBSGUI
{
    public class Frame
    {
        public Frame(string? qTitle = null, string? qText = null)
        {
            if(qTitle != null)
            {
                Title = qTitle;
            }
            else
            {
                
            }
            if (qText != null)
            {
                Text = qText;
            }
            else
            {

            }
        }
        public string Title;
        public string Text;
        public Vector2 Transform = new Vector2();
        public void Show(bool clear = true)
        {
            if (clear)
            {
                Console.Clear();
            }
            else
            {
                
            }
            Console.WriteLine("[" + Title + "]");
            Console.WriteLine(Text);
        }
    }
}
