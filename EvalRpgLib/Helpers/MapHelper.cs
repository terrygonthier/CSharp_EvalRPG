﻿using EvalRpgLib.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvalRpgLib.Helpers
{
    public static class MapHelper
    {
        
        /// <summary>
        /// Retourne le décalage sur X et Y en fonction d'une direction
        /// </summary>
        /// <param name="direction">Une direction</param>
        /// <returns>un tableau d'entier avec : 0 => X, 1 => Y</returns>
        public static int[] GetDirectionOffset(DirectionEnum direction)
        {
            if(direction == DirectionEnum.North) {
                return new int[] { -1 , 0 };
            } else if (direction == DirectionEnum.Est)
            {
                return new int[] { 0, 1 };
            } else if (direction == DirectionEnum.West)
            {
                return new int[] { 0, -1 };
            } else if (direction == DirectionEnum.South)
            {
                return new int[] { 1, 0 };
            }
            return new int[] { 0, 0 };
        }



    }
}
