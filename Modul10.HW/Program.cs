namespace Modul10.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();

            

            bool flag = true;
            do
            {
                Console.WriteLine("Введите два числа через пробел");
                try
                {
                    int[] nums = new int[2];
                    string test = Console.ReadLine();
                    string[] temp = test.Split(new Char[] { ' ' });
                    for (int i = 0; i < temp.Length; i++) 
                    {
                        nums[i] = int.Parse(temp[i]);
                    } 
                    calculator.Calc(nums[0], nums[1]);

                    Console.WriteLine("1 - Продолжить  2 - Стоп");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 2) { flag = false; }
                }
                catch (Exception ex)
                {
                    calculator.Log(ex.Message);
                }

            } while (flag);


        }   
    }
}
