using System;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tcs = new TaskCompletionSource();

            var box = new MessageBox();
            box.WindowIsClosed += (state) =>
            {
                switch (state)
                {
                    case State.OK:
                        Console.WriteLine($"{state} - операция прошла успешно");
                        break;
                    case State.Cancel:
                        Console.WriteLine($"{state} - операция прошла неуспешно (");
                        break;
                }

                tcs.SetResult();
            };

            box.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
