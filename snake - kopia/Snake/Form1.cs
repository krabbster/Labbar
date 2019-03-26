using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game : Form
    {
        int xPos, yPos,xSpeed,ySpeed;
        
        enum Direction { Left, Right, Up, Down }

        LinkedList<Snake> snakes = new LinkedList<Snake>();
        LinkedListNode<Snake> head;
        LinkedListNode<Snake> tail;
        Food food;
        KeyEvents pressedKeys= new KeyEvents();
        Timer timer;

        Random random = new Random();
        
        int size=0;
        public Game()
        {
            InitializeComponent();
            timer = new Timer();
            xPos = 400;
            yPos = 400;
            xSpeed = 10;
            ySpeed = 0;
            addPart(xPos, yPos);
            addFood(500, 400);
        }

        private void addFood(int x, int y)
        {
            food = new Food(x, y);
        }
        private void addPart(int x, int y)
        {
            snakes.AddFirst(new Snake(x, y));
            size++;
            if(size == 1)
            {
                head = snakes.Last;

            }
          
                tail = snakes.First;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var snake in snakes)
            {
                snake.Speed = new Vector(xSpeed, ySpeed);
            }

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            foreach (var snake in snakes)
            {
                snake.Move();
                snake.Draw(e.Graphics, brush);
            }
            food.Draw(e.Graphics, brush);
            FoodCollision(food);
        }

        private void FoodCollision(Food food)
        {
         
            
            if(head.Value.GetX().Equals(food.GetX())&& head.Value.GetY().Equals(food.GetY()))
            {
                int foodType = random.Next(3);
                if (foodType == 0)
                {
                    if(head.Value.Speed.X>0)
                    {
                        addPart(tail.Value.GetX() - 10, tail.Value.GetY());
                    }
                    else if(head.Value.Speed.X<0)
                    {
                        addPart(tail.Value.GetX() + 10, tail.Value.GetY());
                    }
                    else if(head.Value.Speed.Y>0)
                    {
                        addPart(tail.Value.GetX(), tail.Value.GetY() - 10);
                    }
                    else if(head.Value.Speed.Y<0)
                    {
                        addPart(tail.Value.GetX(), tail.Value.GetY() + 10);
                    }

                    foreach (var snake in snakes)
                    {
                        snake.Speed = new Vector(snakes.Last.Value.Speed.X, snakes.Last.Value.Speed.Y);
                    }
                }
                else if (foodType == 1)
                {
                    if (head.Value.Speed.X > 0)
                    {
                        addPart(tail.Value.GetX() - 10, tail.Value.GetY());
                        addPart(tail.Value.GetX() - 10, tail.Value.GetY());
                    }
                    else if (head.Value.Speed.X < 0)
                    {
                        addPart(tail.Value.GetX() + 10, tail.Value.GetY());
                        addPart(tail.Value.GetX() + 10, tail.Value.GetY());
                    }
                    else if (head.Value.Speed.Y > 0)
                    {
                        addPart(tail.Value.GetX(), tail.Value.GetY() - 10);
                        addPart(tail.Value.GetX(), tail.Value.GetY() - 10);
                    }
                    else
                    {
                        addPart(tail.Value.GetX(), tail.Value.GetY() + 10);
                        addPart(tail.Value.GetX(), tail.Value.GetY() + 10);
                    }
                    foreach (var snake in snakes)
                    {
                        snake.Speed = new Vector(snakes.Last.Value.Speed.X, snakes.Last.Value.Speed.Y);
                    }
                }
                else
                {
                    speedUp(snakes);
                }
                
            }
        }

        private void speedUp(LinkedList<Snake> snakes)
        {
            timer.Enabled = true;
            timer.Interval = 10000;
            
            foreach(var snake in snakes)
            {
                snake.Speed.X *= 2;
                snake.Speed.Y *= 2;
            }
               
           
            timer.Enabled = false;
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            
            var node = snakes.Last;
            if(e.KeyCode== Keys.Left)
            {
                if (snakes.Last.Value.Speed.Y != 0)
                {
                    for (int i = 0; i < snakes.Count; i++)
                    {
                        pressedKeys.goLeft(node);
                        Refresh();
                        node = node.Previous;
                        // Form1_Paint(sender, paintEvent);
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (snakes.Last.Value.Speed.Y != 0)
                {
                    for (int i = 0; i < snakes.Count; i++)
                    {
                        pressedKeys.goRight(node);
                        Refresh();
                        node = node.Previous;
                        // Form1_Paint(sender, paintEvent);
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (snakes.Last.Value.Speed.X != 0)
                {
                    for (int i = 0; i < snakes.Count; i++)
                    {
                        pressedKeys.goDown(node);
                        Refresh();
                        node = node.Previous;
                        //Form1_Paint(sender, paintEvent);
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (snakes.Last.Value.Speed.X != 0)
                {

                    for (int i = 0; i < snakes.Count; i++)
                    {
                        pressedKeys.goUp(node);
                        Refresh();
                        node = node.Previous;
                        //Form1_Paint(sender, paintEvent);
                    }
                }
            }
        }

      

        private void timer_Tick(object sender, EventArgs e)
        {

            Invalidate();
        }
    }
}
