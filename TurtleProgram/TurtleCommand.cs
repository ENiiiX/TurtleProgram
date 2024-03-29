﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public class TurtleCommand : ICommand
    {

        private readonly Turtle _turtle;
        private readonly Movement _movement;
        private readonly int _distance;

        public TurtleCommand(Turtle turtle, Movement movement, int distance)
        {

            _turtle = turtle;
            _movement = movement;
            _distance = distance;
        }


        public void Execute()
        {
            if (_movement == Movement.Forward)
            {
                _turtle.forward(_distance);
            }
            else if (_movement == Movement.Backward)
            {
                _turtle.forward(-_distance);
            }

        }
    }
}
