using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class KeyEvents
    {
        Game instance = Activator.CreateInstance<Game>();

        public void goLeft(LinkedListNode<Snake> snakes)
        {
            if (snakes.Value.Speed.Y != 0)
            {
                int PosX1 = snakes.Value.GetX();
                int PosY1 = snakes.Value.GetY();



                moving(snakes);
                void moving(LinkedListNode<Snake> SnakeSegment)

                {
                    int CurrentPosX = SnakeSegment.Value.GetX();
                    int CurrentPosY = SnakeSegment.Value.GetY();
                    if (SnakeSegment.Next != null)
                    {
                        if (SnakeSegment.Value.Speed.Y < (-10))
                        {
                            CurrentPosY = CurrentPosY - 10;
                            SnakeSegment.Value.position.Y = SnakeSegment.Value.position.Y - 10;
                        }
                        else if (SnakeSegment.Value.Speed.Y > 10)
                        {
                            CurrentPosY = CurrentPosY + 10;
                            SnakeSegment.Value.position.Y = SnakeSegment.Value.position.Y + 10;
                        }
                        else
                        {

                        }
                    }

                    if (CurrentPosX == PosX1 && CurrentPosY == PosY1)
                    {
                      /*  if (SnakeSegment.Previous != null)
                        {

                            Snake SnakePart = new Snake(CurrentPosX, CurrentPosY);
                            SnakeSegment.Previous.Value = SnakePart;

                        }*/
                        int x = -10;
                        int y = 0;
                        Vector speed = new Vector(x, y);



                        SnakeSegment.Value.Speed = speed;
                      

                       /* for (int i = 0; i < snakes.Count; i++)
                        {
                            node.Value.Move();
                            node = node.Previous;
                        }*/

                        if (SnakeSegment.Previous != null)
                        {
                            moving(SnakeSegment.Previous);
                        }

                    }
                }
            }
        }

        public void goRight(LinkedListNode<Snake> snakes)
        {
            if (snakes.Value.Speed.Y != 0)
            {
                int PosX1 = snakes.Value.GetX();
                int PosY1 = snakes.Value.GetY();


                moving(snakes);
                void moving(LinkedListNode<Snake> SnakeSegment)

                {
                    int CurrentPosX = SnakeSegment.Value.GetX();
                    int CurrentPosY = SnakeSegment.Value.GetY();
                    if (SnakeSegment.Next != null)
                    {
                        if (SnakeSegment.Value.Speed.Y < (-10))
                        {
                            CurrentPosY = CurrentPosY + 10;
                            SnakeSegment.Value.position.Y = SnakeSegment.Value.position.Y + 10;
                        }
                        else if (SnakeSegment.Value.Speed.Y > 10)
                        {
                            CurrentPosY = CurrentPosY - 10;
                            SnakeSegment.Value.position.Y = SnakeSegment.Value.position.Y - 10;
                        }
                        else
                        {

                        }
                    }
                    if (CurrentPosX == PosX1 && CurrentPosY == PosY1)
                    {
                        /*if (SnakeSegment.Previous != null)
                        {

                            Snake SnakePart = new Snake(CurrentPosX, CurrentPosY);
                            SnakeSegment.Previous.Value = SnakePart;

                        }*/
                        int x = 10;
                        int y = 0;
                        Vector speed = new Vector(x, y);



                        SnakeSegment.Value.Speed = speed;
                       

                      /*  for (int i = 0; i < snakes.Count; i++)
                        {
                            node.Value.Move();
                            node = node.Previous;
                        }*/
                      /*  if (SnakeSegment.Previous != null)
                        {
                            moving(SnakeSegment.Previous);
                        }*/

                        /*
                        if (CurrentPart.Previous != null)
                        {
                            if (CurrentPart.Previous.Value.Speed.Y > 0)
                            {
                                CurrentPart.Previous.Value.Speed.Y = 10;
                            }
                            else
                            {
                                CurrentPart.Previous.Value.Speed.Y = -10;
                            }
                            CurrentPart.Previous.Value.Move();
                        }*/
                    }
                }
            }
        }

        public void goDown(LinkedListNode<Snake> snakes)
        {
            if (snakes.Value.Speed.X != 0)
            {
                int PosX1 = snakes.Value.GetX();
                int PosY1 = snakes.Value.GetY();



                moving(snakes);


                void moving(LinkedListNode<Snake> SnakeSegment)
                {

                    int CurrentPosX = SnakeSegment.Value.GetX();
                    int CurrentPosY = SnakeSegment.Value.GetY();
                    if (SnakeSegment.Next != null)
                    {
                        if (SnakeSegment.Value.Speed.X < (-10))
                        {
                            CurrentPosX = CurrentPosX + 10;
                            SnakeSegment.Value.position.X = SnakeSegment.Value.position.X + 10;
                        }
                        else if (SnakeSegment.Value.Speed.X > 10)
                        {
                            CurrentPosX = CurrentPosX - 10;
                            SnakeSegment.Value.position.X = SnakeSegment.Value.position.X - 10;
                        }
                        else
                        {

                        }
                    }
                    if (CurrentPosX == PosX1 && CurrentPosY == PosY1)
                    {
                      /*  if (SnakeSegment.Previous != null)
                        {

                            Snake SnakePart = new Snake(CurrentPosX, CurrentPosY);
                            SnakeSegment.Previous.Value = SnakePart;

                        }*/
                        int x = 0;
                        int y = 10;
                        Vector speed = new Vector(x, y);

                        

                        SnakeSegment.Value.Speed = speed;
                        

                      /*  for (int i = 0; i < snakes.Count; i++)
                        {
                            node.Value.Move();
                            node = node.Previous;
                        }*/


                        /*if (SnakeSegment.Previous != null)
                        {
                            moving(SnakeSegment.Previous);
                        }*/

                        /* CurrentPart.Value.Move();
                         if (CurrentPart.Previous != null)
                         {
                             if (CurrentPart.Previous.Value.Speed.X > 0)
                             {
                                 CurrentPart.Previous.Value.Speed.X = 10;
                             }
                             else
                             {
                                 CurrentPart.Previous.Value.Speed.X = -10;
                             }
                             CurrentPart.Previous.Value.Move();
                             CurrentPart.Value.Move();
                             CurrentPart = CurrentPart.Previous;
                             moving();
                             CurrentPart.Value.Move();
                         }*/



                    }



                    /* while (CurrentPart != null)
                     {
                         int CurrentPosX = CurrentPart.Value.GetX();
                         int CurrentPosY = CurrentPart.Value.GetY();
                         if (CurrentPosX == PosX && CurrentPosY == PosY)
                         {
                             int x = 0;
                             int y = 5;
                             Vector speed = new Vector(x, y);

                             CurrentPart.Value.Speed = speed;

                             CurrentPart.Value.Move();
                             if (CurrentPart.Previous != null)
                             {
                                 if(CurrentPart.Previous.Value.Speed.X>0)
                                 {
                                     CurrentPart.Previous.Value.Speed.X = 10;
                                 }
                                 else
                                 {
                                     CurrentPart.Previous.Value.Speed.X = -10;
                                 }
                                 CurrentPart.Previous.Value.Move();
                                 goDown(snakes);
                                 CurrentPart.Value.Move();
                             }
                         }*/
                    //CurrentPart = CurrentPart.Previous;
                }
            }
        }
        public void goUp(LinkedListNode<Snake> snakes)
        {
            if (snakes.Value.Speed.X != 0)
            {


                int PosX1 = snakes.Value.GetX();
                int PosY1 = snakes.Value.GetY();
                
                moving(snakes);

                void moving(LinkedListNode<Snake> SnakeSegment)

                {
                    int CurrentPosX = SnakeSegment.Value.GetX();
                    int CurrentPosY = SnakeSegment.Value.GetY();
                    if (SnakeSegment.Next != null)
                    {
                        if (SnakeSegment.Value.Speed.X < (-10))
                        {
                            CurrentPosX = CurrentPosX - 10;
                            SnakeSegment.Value.position.X = SnakeSegment.Value.position.X - 10;
                        }
                        else if (SnakeSegment.Value.Speed.X > 10)
                        {
                            CurrentPosX = CurrentPosX + 10;
                            SnakeSegment.Value.position.X = SnakeSegment.Value.position.X + 10;
                        }
                        else
                        {

                        }
                    }
                    if (CurrentPosX == PosX1 && CurrentPosY == PosY1)
                    {
                        int x = 0;
                        int y = -10;
                        Vector speed = new Vector(x, y);
                        
                        
                     

                        SnakeSegment.Value.Speed = speed;
                       /* for(int i =0; i<snakes.Count; i++)
                        {
                            node.Value.Move();
                            node = node.Previous;
                        }*/

                       /* if (SnakeSegment.Previous != null)
                        {
                            moving(SnakeSegment.Previous);
                        }*/


                    }
                }
            }
        }
    }
}
