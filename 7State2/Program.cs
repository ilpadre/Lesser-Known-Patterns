using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        public interface ITurnstileState
        {
            void Coin(Turnstile t);
            void Pass(Turnstile t);
            string CurrentState();
        }

        public class LockedTurnstileState : ITurnstileState
        {
            public void Coin(Turnstile t)
            {
                t.SetUnlocked();
                t.Unlock();
            }

            public void Pass(Turnstile t)
            {
                t.Alarm();
            }

            public string CurrentState()
            {
                return "Locked";
            }
        }

        public class UnlockedTurnstileState : ITurnstileState
        {
            public void Coin(Turnstile t)
            {
                t.Sucker();
            }

            public void Pass(Turnstile t)
            {
                t.SetLocked();
                t.Lock();
            }

            public string CurrentState()
            {
                return "Unlocked";
            }
        }

        public class Turnstile
        {
            private static ITurnstileState lockedState = new LockedTurnstileState();
            private static ITurnstileState unlockedState = new UnlockedTurnstileState();

            private TurnstileController turnstileController;
            private ITurnstileState state = lockedState;

            public Turnstile(TurnstileController controller)
            {
                turnstileController = controller;
            }

            public void Coin()
            {
                state.Coin(this);
            }

            public void Pass()
            {
                state.Pass(this);
            }

            public void SetLocked()
            {
                state = lockedState;
            }

            public void SetUnlocked()
            {
                state = unlockedState;
            }

            public bool IsLocked()
            {
                return state == lockedState;
            }

            public bool IsUnlocked()
            {
                return state == unlockedState;
            }

            public void Lock()
            {
                turnstileController.Lock();
            }

            public void Unlock()
            {
                turnstileController.Unlock();
            }

            public void Sucker()
            {
                turnstileController.Sucker();
            }

            public void Alarm()
            {
                turnstileController.Alarm();
            }


        }

        public class TurnstileController
        {
            public void Lock()
            {
                Console.WriteLine("Turnstile is now locked.");
            }

            public void Unlock()
            {
                Console.WriteLine("Turnstile is now unlocked.");
            }

            public void Sucker()
            {
                Console.WriteLine("Turnstile was unlocked...thanks for the extra coin.");
            }

            public void Alarm()
            {
                Console.WriteLine("Help! Come see the violence inherent in the system!");
            }
        }

        public class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>
            static void Main()
            {
                var turnstile = new Turnstile(new TurnstileController());
                turnstile.Coin();
                turnstile.Coin();
                turnstile.Pass();
                turnstile.Pass();



                // Wait for user
                Console.ReadLine();
            }
        }
    }
}
