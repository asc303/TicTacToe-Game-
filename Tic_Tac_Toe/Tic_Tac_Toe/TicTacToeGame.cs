using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
   public class TicTacToeGame
    {
        public char[] GAMEdemo = new char[10];
        public void CreateGamedemo() 
        {
            for (int i = 1; i < GAMEdemo.Length; i++)
            {
                GAMEdemo[i] = ' ';
            }   
        }
    }
}