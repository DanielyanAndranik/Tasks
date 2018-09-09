using System;

namespace Miqayelyans_task
{
    public class Rectangle
    {
        public int Length{ get; set; }

        public int Height{ get; set; }
    
        public int PosX { get; set; }

        public int PosY { get; set; }

        public void Draw()
        {
            Console.Clear();
            for(var i = this.PosY; i <= this.PosY + this.Height; i++)
            {
                for(var j = this.PosX; j <= this.PosX + this.Length; j++)
                {
                    if(i > this.PosY && i < this.PosY + this.Height && j > this.PosX && j < this.PosX + this.Length)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    } 
                }  
                Console.Write('\n');  
            }
        }
        public void LeftGrow()
        {
            if(this.PosX > 0)
            {
                this.Length++;
                this.PosX--;
            }           
        }
        public void RightGrow()
        {
            if(this.PosX + this.Length < Console.WindowWidth)
            {
                this.Length++;
            }
        }
        public void TopGrow()
        {
            if(this.PosY > 0)
            {
                this.Height++;
                this.PosY--;               
            }
        }

        public void BottomGrow()
        {
            if(this.PosY + this.Height < Console.WindowHeight)
            {
               this.Height++;
            }

        }

        public void Left()
        {
            if(this.PosX > 0)
            {
                this.PosX--;
            }
        }

        public void Right()
        {
            if(this.PosX + this.Length < Console.WindowWidth)
            {
                this.PosX++;
            }
        }

        public void Top()
        {
            if(this.PosY > 0)
            {
                this.PosY--;                
            }
        }

        public void Bottom()
        {
            if(Console.WindowHeight > this.PosY + this.Height)
            {
                this.PosY++;                
            }
        }

        public bool IsPointInRectangle(int x, int y)
        {
            return (x >= this.PosX && x <= this.PosX + this.Length) && (y >= this.PosY && y<= this.PosY + this.Height);
        }
    }
}