using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class MessageBox
    {
        public event Action<State> WindowIsClosed;

        public async void Open()
        {
            Console.WriteLine("Открываем");
            await Task.Delay(600);
            Console.WriteLine("Закрываем");
            var state = State.Cancel;
            var rand = new Random().Next(2);
            switch (rand)
            {
                case 1:
                    state = State.OK;
                    break;
                case 2:
                    state = State.Cancel;
                    break;
            }

            WindowIsClosed?.Invoke(state);
        }
    }
}
