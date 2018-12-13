using System;
using System.Collections.Generic;
using System.Text;

namespace Labi1
{
    class Map
    {
        public Tile[,] Data;
        protected Tile[,] data
        {
            get { return this.Data; }
            set { this.Data = value; }
        }

        public int Size;
        protected int size
        {
            get { return this.Size; }
            set { this.Size = Math.Abs(value); }
        }

        protected Tile[,] EmptyMapData()
        {
            Tile[,] tmp = new Tile[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tmp[i, j] = new Tile("Wall");
                }
            }
            return tmp;
        }

        public Map(int size)
        {
            this.size = size;

            Tile[,] tmp = new Tile[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tmp[i, j] = new Tile("Wall");
                }
            }
            this.data = tmp;
        }

        public void Print()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    this.data[i, j].Print();
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        public void Start()
        {
            Random random = new Random();
            Tile tmp;
            switch(random.Next(0, 3))
            {
                case 0:
                    tmp = new Tile("Start", true, false, false, false);
                    break;
                case 1:
                    tmp = new Tile("Start", false, true, false, false);
                    break;
                case 2:
                    tmp = new Tile("Start", false, false, true, false);
                    break;
                case 3:
                    tmp = new Tile("Start", false, false, false, true);
                    break;
                default:
                    tmp = new Tile("Start", false, false, false, true);
                    break;
            }
            Tuple<int, int> pos = new Tuple<int, int>(random.Next(1, this.size - 1), random.Next(1, this.size - 1));
            this.data[pos.Item1, pos.Item2] = tmp;
        }

        public void Generate(Tuple<int, int> pos)
        {

        }

        public void Reset()
        {
            this.data = EmptyMapData();
        }
    }
}
