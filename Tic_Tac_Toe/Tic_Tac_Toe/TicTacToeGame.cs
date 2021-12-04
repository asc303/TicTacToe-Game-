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
        public void PlayerInput()
        {
            Console.WriteLine("Enter Your  Play the Games");
            char playerInput = Convert.ToChar(Console.ReadLine());
            char input = char.ToUpper(playerInput);
            if (input == 'X')
            {
                Console.WriteLine("Player Choose :" + playerInput);
                Console.WriteLine("System Choose :" + 'O');
            }
            if (input == 'O')
            {
                Console.WriteLine("Player Choose :" + playerInput);
                Console.WriteLine("System Choose :" + 'X');
            }
            else
                Console.WriteLine("Plese Provide Correct Input to Player Games");
        }
    }
}