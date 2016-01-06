using System;
using System.Speech.Synthesis;

namespace _02.Prisoners
{
    class Program
    {
        static void Print(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 6, 8, 2, 1, 4, 3, 0 };
            bool flag1 = true;
            bool flag2 = true;
            int indexZero;
            int indexNum;
            int change = 0;
            int br = 0;
            Console.WriteLine("You can only move prisoner to \"0\", and if there is a way to the \"0\" ");
            Console.WriteLine("Enter number in range [1..8]");
            Print(array);
            do
            {

                indexZero = Array.IndexOf(array, 0);

                Lable:
                int number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 8)
                {
                    indexNum = Array.IndexOf(array, number);

                }
                else
                {

                    Console.WriteLine("Wrong number!");
                    Console.WriteLine("Enter valid number!");
                    goto Lable;

                }


                if (indexNum == 0)
                {
                    if (indexZero == 1 || indexZero == 3)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }


                if (indexNum == 1)
                {
                    if (indexZero == 2 || indexZero == 4 || indexZero == 0)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                if (indexNum == 2)
                {
                    if (indexZero == 1 || indexZero == 5)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                if (indexNum == 3)
                {
                    if (indexZero == 0 || indexZero == 4 || indexZero == 6)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }


                if (indexNum == 4)
                {
                    if (indexZero == 3 ^ indexZero == 1 ^ indexZero == 5 ^ indexZero == 7)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                if (indexNum == 5)
                {
                    if (indexZero == 4 || indexZero == 2 || indexZero == 8)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                if (indexNum == 6)
                {
                    if (indexZero == 3 || indexZero == 7)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                if (indexNum == 7)
                {
                    if (indexZero == 6 || indexZero == 8 || indexZero == 4)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                if (indexNum == 8)
                {
                    if (indexZero == 7 || indexZero == 4)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            change = array[indexZero];
                            array[indexZero] = array[indexNum];
                            array[indexNum] = change;
                        }
                    }
                    else Console.WriteLine("I can`t move the prisoner!");
                }

                Print(array);

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        flag1 = false;
                    }
                }
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        flag2 = false;
                    }
                }

                br++;
            }
            while (br < 20 || flag1 == true || flag2 == true);

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();


            if (br == 20)
            {
                Console.WriteLine("Lose!");
                synth.Speak("Game over!");
            }
            else
            {
                synth.Speak("You win!");
                Console.WriteLine("Moves done: {0}", br);
            }

        }

    }
}



