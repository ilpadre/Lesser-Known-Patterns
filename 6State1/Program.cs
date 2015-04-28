using System;


namespace State
{
    public class Program
    {
        public enum State { Locked, Unlocked };
        public enum Event { Coin, Pass };

        public class MainApp
        {
            /// <summary>
            /// Entry point into console application.
            /// </summary>
            static void Main()
            {
                var turnstile = new Turnstile(new TurnstileController());
                turnstile.HandleEvent(Event.Coin);
                turnstile.HandleEvent(Event.Coin);
                turnstile.HandleEvent(Event.Pass);
                turnstile.HandleEvent(Event.Pass);



                // Wait for user
                Console.ReadLine();
            }
        }

        public class Turnstile
        {
            private State state = State.Locked;

            private TurnstileController turnstileController;

            public Turnstile(TurnstileController controller)
            {
                turnstileController = controller;
                state = State.Locked;
            }

            public void HandleEvent(Event e)
            {
                switch (state)
                {
                    case State.Locked:
                        switch (e)
                        {
                            case Event.Coin:
                                state = State.Unlocked;
                                turnstileController.Unlock();
                                break;
                            case Event.Pass:
                                turnstileController.Alarm();
                                break;
                            default:
                                break;
                        }
                        break;
                    case State.Unlocked:
                        switch (e)
                        {
                            case Event.Coin:
                                turnstileController.Sucker();
                                break;
                            case Event.Pass:
                                state = State.Locked;
                                turnstileController.Lock();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
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


    }
}
