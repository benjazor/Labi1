using System;
using System.Collections.Generic;
using System.Text;

namespace Labi1
{
    class Tile
    {
        public string Type;
        protected string type
        {
            get { return this.Type; }
            set { this.Type = value; }
        }

        protected Tuple<bool, bool, bool, bool> Anchors;
        public Tuple<bool, bool, bool, bool> anchors
        {
            get { return this.Anchors; }
            set { this.Anchors = value; }
        }

        public Tile(string type, bool top, bool right, bool bottom, bool left)
        {
            this.type = type;
            this.Anchors = new Tuple<bool, bool, bool, bool>(top, right, bottom, left);
        }

        public Tile(string arg)
        {
            switch (arg)
            {
                case "Wall":
                    this.type = "Wall";
                    this.anchors = new Tuple<bool, bool, bool, bool>(false, false, false, false);
                    break;

                case "Path":
                    this.type = "Path";
                    this.anchors = new Tuple<bool, bool, bool, bool>(false, false, false, false);
                    break;

                default:
                    this.Anchors = new Tuple<bool, bool, bool, bool>(false, false, false, false);
                    break;
            }
        }

        public void Print()
        {
            switch (this.type)
            {
                case "Start":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X");
                    Console.ResetColor();
                    break;

                case "Path":
                    Console.Write(" ");
                    break;

                case "Wall":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("#");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("?");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
